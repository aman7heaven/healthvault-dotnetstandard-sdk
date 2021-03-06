// Copyright (c) Microsoft Corporation.  All rights reserved.
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Globalization;
using System.Xml;
using System.Xml.XPath;
using Microsoft.HealthVault.Helpers;

namespace Microsoft.HealthVault.ItemTypes
{
    /// <summary>
    /// Care plan task recurrence representation.
    /// </summary>
    ///
    /// <remarks>
    /// For recurrence rules that cannot be expressed using iCalendar recurrence format, use interval and times-in-interval fields. Ex: Two times in a week.
    /// </remarks>
    ///
    public class CarePlanTaskRecurrence : ItemBase
    {
        /// <summary>
        /// Populates this <see cref="CarePlanTaskRecurrence"/> instance from the data in the specified XML.
        /// </summary>
        ///
        /// <param name="navigator">
        /// The XML to get the CarePlanTaskRecurrence data from.
        /// </param>
        ///
        /// <exception cref="ArgumentNullException">
        /// If <paramref name="navigator"/> parameter is <b>null</b>.
        /// </exception>
        ///
        public override void ParseXml(XPathNavigator navigator)
        {
            Validator.ThrowIfNavigatorNull(navigator);

            _icalRecurrence = XPathHelper.GetOptNavValue(navigator, "ical-recurrence");
            _interval = XPathHelper.GetOptNavValue<CodableValue>(navigator, "interval");
            _timesInInterval = XPathHelper.GetOptNavValueAsInt(navigator, "times-in-interval");
        }

        /// <summary>
        /// Writes the XML representation of the CarePlanTaskRecurrence into
        /// the specified XML writer.
        /// </summary>
        ///
        /// <param name="nodeName">
        /// The name of the outer node for the medical image study series.
        /// </param>
        ///
        /// <param name="writer">
        /// The XML writer into which the CarePlanTaskRecurrence should be
        /// written.
        /// </param>
        ///
        /// <exception cref="ArgumentException">
        /// If <paramref name="nodeName"/> parameter is <b>null</b> or empty.
        /// </exception>
        ///
        /// <exception cref="ArgumentNullException">
        /// If <paramref name="writer"/> parameter is <b>null</b>.
        /// </exception>
        ///
        public override void WriteXml(string nodeName, XmlWriter writer)
        {
            Validator.ThrowIfStringNullOrEmpty(nodeName, "WriteXmlEmptyNodeName");
            Validator.ThrowIfWriterNull(writer);

            if ((_interval != null && _timesInInterval == null) ||
                (_interval == null && _timesInInterval != null))
            {
                throw new InvalidOperationException(Resources.CarePlanTaskRecurrenceIntervalAndTimesBothSet);
            }

            writer.WriteStartElement("recurrence");
            {
                XmlWriterHelper.WriteOptString(writer, "ical-recurrence", _icalRecurrence);
                XmlWriterHelper.WriteOpt(writer, "interval", _interval);
                XmlWriterHelper.WriteOptInt(writer, "times-in-interval", _timesInInterval);
            }

            writer.WriteEndElement();
        }

        /// <summary>
        /// Gets or sets the ical-recurrence
        /// </summary>
        /// <remarks>
        ///  Uses the iCalendar format for recurrence specification as per RFC 2445, Section 4.3.10.
        /// </remarks>
        ///
        public string IcalRecurrence
        {
            get
            {
                return _icalRecurrence;
            }

            set
            {
                Validator.ThrowIfStringNullOrEmpty(value, "IcalRecurrence");
                Validator.ThrowIfStringIsWhitespace(value, "IcalRecurrence");

                _icalRecurrence = value;
                _interval = null;
                _timesInInterval = null;
            }
        }

        private string _icalRecurrence;

        /// <summary>
        /// Gets or sets the recurrence interval.
        /// </summary>
        /// <remarks>
        /// For example: day, month, year.
        /// </remarks>
        ///
        public CodableValue Interval
        {
            get
            {
                return _interval;
            }

            set
            {
                _interval = value;
                _icalRecurrence = null;
            }
        }

        private CodableValue _interval;

        /// <summary>
        /// Gets or sets the number of times in the interval.
        /// </summary>
        /// <remarks>
        /// Example: Two times in a week would be stored as interval = week, times-in-interval = 2.
        /// </remarks>
        ///
        public int? TimesInInterval
        {
            get
            {
                return _timesInInterval;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(Resources.CarePlanTaskRecurrenceInvalidTimeInInterval, nameof(TimesInInterval));
                }

                _timesInInterval = value;
                _icalRecurrence = null;
            }
        }

        private int? _timesInInterval;

        /// <summary>
        /// Gets a string representation of the CarePlanTaskRecurrence.
        /// </summary>
        ///
        /// <returns>
        /// A string representation of the CarePlanTaskRecurrence.
        /// </returns>
        ///
        public override string ToString()
        {
            if (_icalRecurrence != null)
            {
                return _icalRecurrence;
            }

            if (_interval != null &&
                _timesInInterval != null)
            {
                return string.Format(
                    CultureInfo.CurrentUICulture,
                    Resources.CarePlanTaskRecurrenceFormat,
                    _timesInInterval,
                    _interval.Text);
            }

            return string.Empty;
        }
    }
}
