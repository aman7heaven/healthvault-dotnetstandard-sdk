// Copyright (c) Microsoft Corporation.  All rights reserved.
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using Microsoft.HealthVault.Clients;
using Microsoft.HealthVault.Helpers;
using Microsoft.HealthVault.Thing;

namespace Microsoft.HealthVault.ItemTypes
{
    /// <summary>
    /// Represents a thing type that encapsulates a medical appointment.
    /// </summary>
    ///
    public class Appointment : ThingBase
    {
        /// <summary>
        /// Creates a new instance of the <see cref="Appointment"/> class with default
        /// values.
        /// </summary>
        ///
        /// <remarks>
        /// The item isn't added to the health record until the <see cref="IThingClient.CreateNewThingsAsync{ThingBase}(Guid, ICollection{ThingBase})"/> method is called.
        /// </remarks>
        ///
        public Appointment()
            : base(TypeId)
        {
        }

        /// <summary>
        /// Creates a new instance of the <see cref="Appointment"/> class with
        /// the specified date and time.
        /// </summary>
        ///
        /// <param name="when">
        /// The date and time for the appointment.
        /// </param>
        ///
        /// <exception cref="ArgumentException">
        /// The <paramref name="when"/> parameter is <b>null</b>.
        /// </exception>
        ///
        public Appointment(HealthServiceDateTime when)
            : base(TypeId)
        {
            When = when;
        }

        /// <summary>
        /// Retrieves the unique identifier for the item type.
        /// </summary>
        ///
        /// <value>
        /// A GUID.
        /// </value>
        ///
        public static new readonly Guid TypeId =
            new Guid("4B18AEB6-5F01-444C-8C70-DBF13A2F510B");

        /// <summary>
        /// Populates this appointment instance from the data in the XML.
        /// </summary>
        ///
        /// <param name="typeSpecificXml">
        /// The XML to get the appointment data from.
        /// </param>
        ///
        /// <exception cref="InvalidOperationException">
        /// The first node in <paramref name="typeSpecificXml"/> is not
        /// an appointment node.
        /// </exception>
        ///
        protected override void ParseXml(IXPathNavigable typeSpecificXml)
        {
            XPathNavigator appointmentNav =
                typeSpecificXml.CreateNavigator().SelectSingleNode("appointment");

            Validator.ThrowInvalidIfNull(appointmentNav, Resources.AppointmentUnexpectedNode);

            // <when>
            _when = new HealthServiceDateTime();
            _when.ParseXml(appointmentNav.SelectSingleNode("when"));

            // <duration>
            _duration =
                XPathHelper.GetOptNavValue<DurationValue>(
                    appointmentNav,
                    "duration");

            // <service>
            XPathNavigator serviceNav =
                appointmentNav.SelectSingleNode("service");
            if (serviceNav != null)
            {
                _service = new CodableValue();
                _service.ParseXml(serviceNav);
            }

            // <clinic>
            XPathNavigator clinicNav =
                appointmentNav.SelectSingleNode("clinic");

            if (clinicNav != null)
            {
                _clinic = new PersonItem();
                _clinic.ParseXml(clinicNav);
            }

            // <specialty>
            XPathNavigator specialtyNav =
                appointmentNav.SelectSingleNode("specialty");
            if (specialtyNav != null)
            {
                _specialty = new CodableValue();
                _specialty.ParseXml(specialtyNav);
            }

            // <status>
            XPathNavigator statusNav =
                appointmentNav.SelectSingleNode("status");
            if (statusNav != null)
            {
                _status = new CodableValue();
                _status.ParseXml(statusNav);
            }

            // <care-class>
            XPathNavigator careClassNav =
                appointmentNav.SelectSingleNode("care-class");
            if (careClassNav != null)
            {
                _careClass = new CodableValue();
                _careClass.ParseXml(careClassNav);
            }
        }

        /// <summary>
        /// Writes the appointment data to the specified XmlWriter.
        /// </summary>
        ///
        /// <param name="writer">
        /// The XmlWriter to write the appointment data to.
        /// </param>
        ///
        /// <exception cref="ArgumentNullException">
        /// If <paramref name="writer"/> is <b>null</b>.
        /// </exception>
        ///
        public override void WriteXml(XmlWriter writer)
        {
            Validator.ThrowIfArgumentNull(writer, nameof(writer), Resources.WriteXmlNullWriter);
            Validator.ThrowSerializationIfNull(_when, Resources.AppointmentWhenNotSet);

            // <appointment>
            writer.WriteStartElement("appointment");

            // <when>
            _when.WriteXml("when", writer);

            // <duration>
            XmlWriterHelper.WriteOpt(
                writer,
                "duration",
                _duration);

            // <service>
            Service?.WriteXml("service", writer);

            // <clinic>
            Clinic?.WriteXml("clinic", writer);

            // <specialty>
            Specialty?.WriteXml("specialty", writer);

            // <status>
            Status?.WriteXml("status", writer);

            // <care-class>
            CareClass?.WriteXml("care-class", writer);

            // </appointment>
            writer.WriteEndElement();
        }

        /// <summary>
        /// Gets or sets the date when the appointment occurred.
        /// </summary>
        ///
        /// <value>
        /// A <see cref="HealthServiceDateTime"/> instance representing
        /// the date. The default value is the current year, month, and day.
        /// </value>
        ///
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="value"/> parameter is <b>null</b>.
        /// </exception>
        ///
        public HealthServiceDateTime When
        {
            get { return _when; }

            set
            {
                Validator.ThrowIfArgumentNull(value, nameof(When), Resources.WhenNullValue);
                _when = value;
            }
        }

        private HealthServiceDateTime _when = new HealthServiceDateTime();

        /// <summary>
        /// Gets or sets the duration of the appointment.
        /// </summary>
        ///
        /// <value>
        /// A <see cref="DurationValue"/> instance representing  the duration.
        /// </value>
        ///
        /// <remarks>
        /// Set the value to <b>null</b> if the duration should not be stored.
        /// </remarks>
        ///
        public DurationValue Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        private DurationValue _duration;

        /// <summary>
        /// Gets or sets the service for the appointment.
        /// </summary>
        ///
        /// <value>
        /// A <see cref="CodableValue"/> instance representing the service.
        /// </value>
        ///
        /// <remarks>
        /// Set the value to <b>null</b> if the service should not be
        /// stored.
        /// </remarks>
        ///
        public CodableValue Service
        {
            get { return _service; }
            set { _service = value; }
        }

        private CodableValue _service;

        /// <summary>
        /// Gets or sets the clinic information.
        /// </summary>
        ///
        /// <value>
        /// A <see cref="PersonItem"/> instance representing the clinic information.
        /// </value>
        ///
        /// <remarks>
        /// Set the value to <b>null</b> if the clinic information
        /// should not be stored.
        /// </remarks>
        ///
        public PersonItem Clinic
        {
            get { return _clinic; }
            set { _clinic = value; }
        }

        private PersonItem _clinic;

        /// <summary>
        /// Gets or sets the specialty for the appointment.
        /// </summary>
        ///
        /// <value>
        /// A <see cref="CodableValue"/> instance representing the specialty.
        /// </value>
        ///
        /// <remarks>
        /// Set the value to <b>null</b> if the specialty should not be
        /// stored.
        /// </remarks>
        ///
        public CodableValue Specialty
        {
            get { return _specialty; }
            set { _specialty = value; }
        }

        private CodableValue _specialty;

        /// <summary>
        /// Gets or sets the status for the appointment.
        /// </summary>
        ///
        /// <value>
        /// A <see cref="CodableValue"/> instance representing the status.
        /// </value>
        ///
        /// <remarks>
        /// Set the value to <b>null</b> if the status should not be
        /// stored.
        /// </remarks>
        ///
        public CodableValue Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private CodableValue _status;

        /// <summary>
        /// Gets or sets the care class for the appointment.
        /// </summary>
        ///
        /// <value>
        /// A <see cref="CodableValue"/> instance representing the care class.
        /// </value>
        ///
        /// <remarks>
        /// Set the value to <b>null</b> if the care class should not be
        /// stored.
        /// </remarks>
        ///
        public CodableValue CareClass
        {
            get { return _careClass; }
            set { _careClass = value; }
        }

        private CodableValue _careClass;

        /// <summary>
        /// Gets a string representation of the appointment item.
        /// </summary>
        ///
        /// <returns>
        /// A string representation of the appointment item.
        /// </returns>
        ///
        public override string ToString()
        {
            StringBuilder result = new StringBuilder(200);

            result.Append(When);

            if (Duration != null)
            {
                result.AppendFormat(
                    Resources.ListFormat,
                    Duration.ToString());
            }

            if (Clinic != null)
            {
                result.AppendFormat(
                    Resources.ListFormat,
                    Clinic.ToString());
            }

            if (Status != null)
            {
                result.AppendFormat(
                    Resources.ListFormat,
                    Status.Text);
            }

            if (Service != null)
            {
                result.AppendFormat(
                    Resources.ListFormat,
                    Service.Text);
            }

            return result.ToString();
        }
    }
}
