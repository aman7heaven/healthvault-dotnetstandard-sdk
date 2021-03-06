// Copyright (c) Microsoft Corporation.  All rights reserved.
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.XPath;
using Microsoft.HealthVault.Clients;
using Microsoft.HealthVault.Exceptions;
using Microsoft.HealthVault.Helpers;
using Microsoft.HealthVault.Thing;

namespace Microsoft.HealthVault.ItemTypes
{
    /// <summary>
    /// Represents thing type that contains information about an immunization.
    /// </summary>
    ///
    public class Immunization : ThingBase
    {
        /// <summary>
        /// Creates a new instance of the <see cref="Immunization"/> class with
        /// default values.
        /// </summary>
        ///
        /// <remarks>
        /// The item is not added to the health record until the <see cref="IThingClient.CreateNewThingsAsync{ThingBase}(Guid, ICollection{ThingBase})"/> method is called.
        /// </remarks>
        ///
        public Immunization()
            : base(TypeId)
        {
        }

        /// <summary>
        /// Creates a new instance of the <see cref="Immunization"/> class
        /// specifying the mandatory values.
        /// </summary>
        ///
        /// <param name="name">
        /// The name of the immunization.
        /// </param>
        ///
        /// <param name="dateAdministrated">
        /// The approximate date that the immunization was adminstrated.
        /// </param>
        ///
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="name"/> parameter is <b>null</b>.
        /// </exception>
        ///
        public Immunization(CodableValue name, ApproximateDateTime dateAdministrated)
            : base(TypeId)
        {
            Name = name;
            DateAdministrated = dateAdministrated;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="Immunization"/> class
        /// specifying the mandatory values.
        /// </summary>
        ///
        /// <param name="name">
        /// The name of the immunization.
        /// </param>
        ///
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="name"/> parameter is null.
        /// </exception>
        ///
        public Immunization(CodableValue name)
            : base(TypeId)
        {
            Name = name;
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
            new Guid("cd3587b5-b6e1-4565-ab3b-1c3ad45eb04f");

        /// <summary>
        /// Populates this <see cref="Immunization"/> instance from the data in the XML.
        /// </summary>
        ///
        /// <param name="typeSpecificXml">
        /// The XML to get the immunization data from.
        /// </param>
        ///
        /// <exception cref="InvalidOperationException">
        /// The first node in <paramref name="typeSpecificXml"/> is not
        /// an immunization node.
        /// </exception>
        ///
        protected override void ParseXml(IXPathNavigable typeSpecificXml)
        {
            XPathNavigator itemNav =
                typeSpecificXml.CreateNavigator().SelectSingleNode(
                    "immunization");

            Validator.ThrowInvalidIfNull(itemNav, Resources.ImmunizationUnexpectedNode);

            // <name>
            _name.ParseXml(itemNav.SelectSingleNode("name"));

            // <administration-date>
            _dateAdministrated =
                XPathHelper.GetOptNavValue<ApproximateDateTime>(
                    itemNav,
                    "administration-date");

            // <administrator>
            _administrator =
                XPathHelper.GetOptNavValue<PersonItem>(
                    itemNav,
                    "administrator");

            // <manufacturer>
            _manufacturer =
                XPathHelper.GetOptNavValue<CodableValue>(itemNav, "manufacturer");

            // <lot>
            _lot = XPathHelper.GetOptNavValue(itemNav, "lot");

            // <route>
            _route =
                XPathHelper.GetOptNavValue<CodableValue>(
                    itemNav,
                    "route");

            // <expiration-date> approx-date-time
            _expirationDate =
                XPathHelper.GetOptNavValue<ApproximateDate>(
                    itemNav,
                    "expiration-date");

            // <sequence>
            _sequence =
                XPathHelper.GetOptNavValue(itemNav, "sequence");

            // <anatomic-surface>
            _anatomicSurface =
                XPathHelper.GetOptNavValue<CodableValue>(
                    itemNav,
                    "anatomic-surface");

            // <adverse-event> string
            _adverseEvent =
                XPathHelper.GetOptNavValue(itemNav, "adverse-event");

            // <consent>
            _consent =
                XPathHelper.GetOptNavValue(itemNav, "consent");
        }

        /// <summary>
        /// Writes the immunization data to the specified XmlWriter.
        /// </summary>
        ///
        /// <param name="writer">
        /// The XmlWriter to write the immunization data to.
        /// </param>
        ///
        /// <exception cref="ArgumentNullException">
        /// If <paramref name="writer"/> is <b>null</b>.
        /// </exception>
        ///
        /// <exception cref="ThingSerializationException">
        /// The <see cref="Name"/> has not been set.
        /// </exception>
        ///
        public override void WriteXml(XmlWriter writer)
        {
            Validator.ThrowIfWriterNull(writer);
            Validator.ThrowSerializationIfNull(_name.Text, Resources.ImmunizationNameNotSet);

            // <immunization>
            writer.WriteStartElement("immunization");

            _name.WriteXml("name", writer);

            // <administration-date>
            XmlWriterHelper.WriteOpt(
                writer,
                "administration-date",
                _dateAdministrated);

            // <administrator>
            XmlWriterHelper.WriteOpt(
                writer,
                "administrator",
                Administrator);

            // <manufacturer>
            XmlWriterHelper.WriteOpt(
                writer,
                "manufacturer",
                _manufacturer);

            // <lot>
            XmlWriterHelper.WriteOptString(
                writer,
                "lot",
                _lot);

            // <route>
            XmlWriterHelper.WriteOpt(
                writer,
                "route",
                Route);

            // <expiration-date>
            XmlWriterHelper.WriteOpt(
                writer,
                "expiration-date",
                _expirationDate);

            // <sequence>
            XmlWriterHelper.WriteOptString(
                writer,
                "sequence",
                _sequence);

            // <anatomic-surface>
            XmlWriterHelper.WriteOpt(
                writer,
                "anatomic-surface",
                AnatomicSurface);

            // <adverse-event>
            XmlWriterHelper.WriteOptString(
                writer,
                "adverse-event",
                _adverseEvent);

            // <consent>
            XmlWriterHelper.WriteOptString(
                writer,
                "consent",
                _consent);

            // </immunization>
            writer.WriteEndElement();
        }

        /// <summary>
        /// Gets or sets the name of the immunization.
        /// </summary>
        ///
        /// <value>
        /// A <see cref="CodableValue"/> instance representing the name.
        /// </value>
        ///
        /// <remarks>
        /// The preferred vocabulary for the immunization name is "vaccines-cvx".
        /// </remarks>
        ///
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="value"/> parameter is null during set.
        /// </exception>
        ///
        public CodableValue Name
        {
            get { return _name; }

            set
            {
                Validator.ThrowIfArgumentNull(value, nameof(Name), Resources.ImmunizationNameMandatory);
                _name = value;
            }
        }

        private CodableValue _name = new CodableValue();

        /// <summary>
        /// Gets or sets the date the immunization was administrated.
        /// </summary>
        ///
        /// <value>
        /// An <see cref="ApproximateDateTime"/> instance representing the date.
        /// </value>
        ///
        public ApproximateDateTime DateAdministrated
        {
            get { return _dateAdministrated; }
            set { _dateAdministrated = value; }
        }

        private ApproximateDateTime _dateAdministrated;

        /// <summary>
        /// Gets or sets the name of the administrator of the immunization.
        /// </summary>
        ///
        /// <value>
        /// A <see cref="PersonItem"/> instance representing the person.
        /// </value>
        ///
        /// <remarks>
        /// Set the value to null if the administrator should not be stored.
        /// </remarks>
        ///
        public PersonItem Administrator
        {
            get { return _administrator; }
            set { _administrator = value; }
        }

        private PersonItem _administrator;

        /// <summary>
        /// Gets or sets the manufacturer of the vaccine.
        /// </summary>
        ///
        /// <value>
        /// A string representing the manufacturer.
        /// </value>
        ///
        /// <remarks>
        /// Set the value to null if the manufacturer should not be stored.
        /// The preferred vocabulary for the immunization manufacturer is "vaccine-manufacturers-mvx".
        /// </remarks>
        ///
        public CodableValue Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }

        private CodableValue _manufacturer;

        /// <summary>
        /// Gets or sets the lot of the vaccine.
        /// </summary>
        ///
        /// <value>
        /// A string representing the lot.
        /// </value>
        ///
        /// <remarks>
        /// Set the value to null if the lot should not be stored.
        /// </remarks>
        ///
        /// <exception cref="ArgumentException">
        /// If <paramref name="value"/> contains only whitespace.
        /// </exception>
        ///
        public string Lot
        {
            get { return _lot; }

            set
            {
                Validator.ThrowIfStringIsWhitespace(value, "Lot");
                _lot = value;
            }
        }

        private string _lot;

        /// <summary>
        /// Gets or sets the medical route for the immunization.
        /// </summary>
        ///
        /// <value>
        /// A <see cref="CodableValue"/> instance representing the route.
        /// </value>
        ///
        public CodableValue Route
        {
            get { return _route; }
            set { _route = value; }
        }

        private CodableValue _route;

        /// <summary>
        /// Gets or sets the expiration date for the vaccine.
        /// </summary>
        ///
        /// <value>
        /// An <see cref="ApproximateDate"/> instance representing the date.
        /// </value>
        ///
        public ApproximateDate ExpirationDate
        {
            get { return _expirationDate; }
            set { _expirationDate = value; }
        }

        private ApproximateDate _expirationDate;

        /// <summary>
        /// Gets or sets the sequence for the immunization.
        /// </summary>
        ///
        /// <value>
        /// A string representing the sequence.
        /// </value>
        ///
        /// <remarks>
        /// Set the value to null if the consent should not be stored.
        /// </remarks>
        ///
        /// <exception cref="ArgumentException">
        /// If <paramref name="value"/> contains only whitespace.
        /// </exception>
        ///
        public string Sequence
        {
            get { return _sequence; }

            set
            {
                Validator.ThrowIfStringIsWhitespace(value, "Sequence");
                _sequence = value;
            }
        }

        private string _sequence;

        /// <summary>
        /// Gets or sets the anatomic surface for the immunization.
        /// </summary>
        ///
        /// <value>
        /// A <see cref="CodableValue"/> instance representing the surface.
        /// </value>
        ///
        public CodableValue AnatomicSurface
        {
            get { return _anatomicSurface; }
            set { _anatomicSurface = value; }
        }

        private CodableValue _anatomicSurface;

        /// <summary>
        /// Gets or sets any adverse event description for the immunization.
        /// </summary>
        ///
        /// <value>
        /// A string representing the event description.
        /// </value>
        ///
        /// <remarks>
        /// Set the value to null if the description should not be stored.
        /// </remarks>
        ///
        /// <exception cref="ArgumentException">
        /// If <paramref name="value"/> contains only whitespace.
        /// </exception>
        ///
        public string AdverseEvent
        {
            get { return _adverseEvent; }

            set
            {
                Validator.ThrowIfStringIsWhitespace(value, "AdverseEvent");
                _adverseEvent = value;
            }
        }

        private string _adverseEvent;

        /// <summary>
        /// Gets or sets the consent description for the immunization.
        /// </summary>
        ///
        /// <value>
        /// A string representing the consent description.
        /// </value>
        ///
        /// <remarks>
        /// Set the value to null if the consent should not be stored.
        /// </remarks>
        ///
        /// <exception cref="ArgumentException">
        /// If <paramref name="value"/> contains only whitespace.
        /// </exception>
        ///
        public string Consent
        {
            get { return _consent; }

            set
            {
                Validator.ThrowIfStringIsWhitespace(value, "Consent");
                _consent = value;
            }
        }

        private string _consent;

        /// <summary>
        /// Gets a string representation of the immunization item.
        /// </summary>
        ///
        /// <returns>
        /// A string representation of the immunization item.
        /// </returns>
        ///
        public override string ToString()
        {
            string result = Name.ToString();

            if (DateAdministrated != null)
            {
                result =
                    string.Format(
                        Resources.ImmunizationToStringFormat,
                        Name.ToString(),
                        DateAdministrated.ToString());
            }

            return result;
        }
    }
}
