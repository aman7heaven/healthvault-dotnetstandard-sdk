// Copyright(c) Microsoft Corporation.
// This content is subject to the Microsoft Reference Source License,
// see http://www.microsoft.com/resources/sharedsource/licensingbasics/sharedsourcelicenses.mspx.
// All other rights reserved.

using System.Xml;
using System.Xml.XPath;
using Microsoft.HealthVault.Helpers;

namespace Microsoft.HealthVault.ItemTypes
{
    /// <summary>
    /// Represents an occurrence of an event, such as an activity,
    /// period of awakening during sleep, and so on.
    /// </summary>
    ///
    public class Occurrence : ItemBase
    {
        /// <summary>
        /// Creates a new instance of the <see cref="Occurrence"/> class with
        /// default values.
        /// </summary>
        ///
        public Occurrence()
        {
        }

        /// <summary>
        /// Creates a new instance of the <see cref="Occurrence"/> class with
        /// the specified approximate time and duration.
        /// </summary>
        ///
        /// <param name="when">
        /// The approximate time for the occurrence.
        /// </param>
        ///
        /// <param name="minutes">
        /// The duration of the occurrence in minutes.
        /// </param>
        ///
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="when"/> parameter is <b>null</b>.
        /// </exception>
        ///
        /// <exception cref="ArgumentOutOfRangeException">
        /// The <paramref name="minutes"/> parameter is negative.
        /// </exception>
        ///
        public Occurrence(ApproximateTime when, int minutes)
        {
            this.When = when;
            this.Minutes = minutes;
        }

        /// <summary>
        /// Populates the data from the specified XML.
        /// </summary>
        ///
        /// <param name="navigator">
        /// The XML containing the occurrence information.
        /// </param>
        ///
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="navigator"/> parameter is <b>null</b>.
        /// </exception>
        ///
        public override void ParseXml(XPathNavigator navigator)
        {
            Validator.ThrowIfNavigatorNull(navigator);

            this.when = new ApproximateTime();
            this.when.ParseXml(navigator.SelectSingleNode("when"));

            this.minutes = navigator.SelectSingleNode("minutes").ValueAsInt;
        }

        /// <summary>
        /// Writes the XML representation of the occurrence into
        /// the specified XML writer.
        /// </summary>
        ///
        /// <param name="nodeName">
        /// The name of the outer node for the occurrence.
        /// </param>
        ///
        /// <param name="writer">
        /// The XML writer into which the occurrence should be
        /// written.
        /// </param>
        ///
        /// <exception cref="ArgumentException">
        /// The <paramref name="nodeName"/> parameter is <b>null</b> or empty.
        /// </exception>
        ///
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="writer"/> parameter is <b>null</b>.
        /// </exception>
        ///
        /// <exception cref="HealthRecordItemSerializationException">
        /// The <see cref="When"/> property is <b>null</b>, or the <see cref="Minutes"/>
        /// property is less than or equal to zero.
        /// </exception>
        ///
        public override void WriteXml(string nodeName, XmlWriter writer)
        {
            Validator.ThrowIfStringNullOrEmpty(nodeName, "nodeName");
            Validator.ThrowIfWriterNull(writer);
            Validator.ThrowSerializationIfNull(this.when, "OccurrenceWhenNotSet");
            Validator.ThrowSerializationIfNull(this.minutes, "OccurrenceMinutesNotSet");

            writer.WriteStartElement(nodeName);

            this.when.WriteXml("when", writer);
            writer.WriteElementString("minutes", this.minutes.ToString());

            writer.WriteEndElement();
        }

        /// <summary>
        /// Gets or sets the time of the occurrence.
        /// </summary>
        ///
        /// <value>
        /// An <see cref="ApproximateTime"/> value representing the
        /// time of the occurrence.
        /// </value>
        ///
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="value"/> parameter is <b>null</b> on set.
        /// </exception>
        ///
        public ApproximateTime When
        {
            get { return this.when; }

            set
            {
                Validator.ThrowIfArgumentNull(value, "When", "OccurrenceWhenMandatory");
                this.when = value;
            }
        }

        private ApproximateTime when;

        /// <summary>
        /// Gets or sets the duration of the occurrence in minutes.
        /// </summary>
        ///
        /// <value>
        /// An integer representing the duration.
        /// </value>
        ///
        /// <exception cref="ArgumentOutOfRangeException">
        /// The <paramref name="value"/> parameter is less than or equal to zero.
        /// </exception>
        ///
        public int Minutes
        {
            get { return (int)this.minutes; }

            set
            {
                Validator.ThrowArgumentOutOfRangeIf(value <= 0, "Minutes", "OccurrenceMinutesMustBePositive");
                this.minutes = value;
            }
        }

        private int? minutes;
    }
}
