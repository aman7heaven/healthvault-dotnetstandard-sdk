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
    /// Encounter class contains information related to a medical encounter.
    /// </summary>
    ///
    /// <remarks>
    /// It describes the medical encounter a person has.
    /// </remarks>
    ///
    public class Encounter : ThingBase
    {
        /// <summary>
        /// Creates a new instance of the <see cref="Encounter"/> class with default values.
        /// </summary>
        ///
        /// <remarks>
        /// The item is not added to the health record until the <see cref="IThingClient.CreateNewThingsAsync{ThingBase}(Guid, ICollection{ThingBase})"/> method is called.
        /// </remarks>
        ///
        public Encounter()
            : base(TypeId)
        {
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
            new Guid("464083cc-13de-4f3e-a189-da8e47d5651b");

        /// <summary>
        /// Information related to a medical encounter.
        /// </summary>
        ///
        /// <param name="typeSpecificXml">
        /// The XML to get the medical encounter data from.
        /// </param>
        ///
        /// <exception cref="InvalidOperationException">
        /// If the first node in <paramref name="typeSpecificXml"/> is not
        /// a encounter node.
        /// </exception>
        ///
        protected override void ParseXml(IXPathNavigable typeSpecificXml)
        {
            XPathNavigator itemNav =
                typeSpecificXml.CreateNavigator().SelectSingleNode("encounter");

            Validator.ThrowInvalidIfNull(itemNav, Resources.EncounterUnexpectedNode);

            // when
            _when =
                XPathHelper.GetOptNavValue<HealthServiceDateTime>(itemNav, "when");

            // type
            _type =
                XPathHelper.GetOptNavValue<CodableValue>(itemNav, "type");

            // reason
            _reason =
                XPathHelper.GetOptNavValue(itemNav, "reason");

            // duration
            _duration =
                XPathHelper.GetOptNavValue<DurationValue>(itemNav, "duration");

            // consent-granted
            _consentGranted =
                XPathHelper.GetOptNavValueAsBool(itemNav, "consent-granted");

            // facility
            _facility =
                XPathHelper.GetOptNavValue<Organization>(itemNav, "facility");
        }

        /// <summary>
        /// Writes the medical encounter data to the specified XmlWriter.
        /// </summary>
        ///
        /// <param name="writer">
        /// The XmlWriter to write the medical encounter data to.
        /// </param>
        ///
        /// <exception cref="ArgumentNullException">
        /// If <paramref name="writer"/> is <b>null</b>.
        /// </exception>
        ///
        public override void WriteXml(XmlWriter writer)
        {
            Validator.ThrowIfWriterNull(writer);

            // <encounter>
            writer.WriteStartElement("encounter");

            // <when>
            XmlWriterHelper.WriteOpt(
                writer,
                "when",
                _when);

            // <type>
            XmlWriterHelper.WriteOpt(
                writer,
                "type",
                _type);

            // <reason>
            XmlWriterHelper.WriteOptString(
                writer,
                "reason",
                _reason);

            // <duration>
            XmlWriterHelper.WriteOpt(
                writer,
                "duration",
                _duration);

            // <consent-granted>
            XmlWriterHelper.WriteOptBool(
                writer,
                "consent-granted",
                _consentGranted);

            // <facility>
            XmlWriterHelper.WriteOpt(
                writer,
                "facility",
                _facility);

            // </encounter>
            writer.WriteEndElement();
        }

        /// <summary>
        /// Gets or sets the date/time when the medical encounter occurred.
        /// </summary>
        ///
        /// <value>
        /// A <see cref="HealthServiceDateTime"/> instance representing
        /// the date. The default value is the current year, month, and day.
        /// </value>
        ///
        public HealthServiceDateTime When
        {
            get { return _when; }
            set { _when = value; }
        }

        private HealthServiceDateTime _when;

        /// <summary>
        /// Gets or sets the reason of the medical encounter. The description
        /// of the encounter.
        /// </summary>
        ///
        /// <value>
        /// It is a string.
        /// </value>
        ///
        /// <remarks>
        /// Examples include heart failure, broken legs, or annual physical
        /// </remarks>
        ///
        /// <exception cref="ArgumentException">
        /// If <paramref name="value"/> contains only whitespace.
        /// </exception>
        ///
        public string Reason
        {
            get { return _reason; }

            set
            {
                Validator.ThrowIfStringIsWhitespace(value, "Reason");
                _reason = value;
            }
        }

        private string _reason;

        /// <summary>
        /// Gets or sets the type of medical encounter.
        /// </summary>
        ///
        /// <value>
        /// A CodableValue representing the encounter type.
        /// </value>
        ///
        public CodableValue Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private CodableValue _type;

        /// <summary>
        /// Gets or sets the encounter duration.
        /// </summary>
        ///
        /// <remarks>
        /// The duration of the medical encounter. Set the value to <b>null</b> if the duration should not be
        /// stored.
        /// </remarks>
        ///
        public DurationValue Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        private DurationValue _duration;

        /// <summary>
        /// Gets and sets a value indicating whether consent
        /// has been granted by the person.
        /// </summary>
        ///
        /// <value>
        /// <b>true</b>if consent has been granted for this medical encounter;
        /// otherwise, <b>false</b>. If <b>null</b>, it is unknown whether consent has been granted.
        /// </value>
        ///
        public bool? ConsentGranted
        {
            get { return _consentGranted; }
            set { _consentGranted = value; }
        }

        private bool? _consentGranted;

        /// <summary>
        /// The facility where the encounter occurred.
        /// </summary>
        ///
        public Organization Facility
        {
            get { return _facility; }

            set
            {
                _facility = value;
            }
        }

        private Organization _facility;

        /// <summary>
        /// Gets a string representation of the encounter item.
        /// </summary>
        ///
        /// <returns>
        /// A string representation of the encounter item.
        /// </returns>
        ///
        public override string ToString()
        {
            StringBuilder result = new StringBuilder(200);

            if (Type != null)
            {
                result.Append(Type);
            }

            if (!string.IsNullOrEmpty(Reason))
            {
                if (Type != null)
                {
                    result.Append(
                        Resources.ListSeparator);
                }

                result.Append(Reason);
            }

            return result.ToString();
        }
    }
}
