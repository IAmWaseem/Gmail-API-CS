/*
 * GmailAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 01/27/2017
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using GmailAPI.PCL;
using GmailAPI.PCL.Utilities;

namespace GmailAPI.PCL.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum MessageListVisibilityEnum
    {
        HIDE, //TODO: Write general description for this method
        SHOW, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type MessageListVisibilityEnum
    /// </summary>
    public static class MessageListVisibilityEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "hide", "show" };

        /// <summary>
        /// Converts a MessageListVisibilityEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The MessageListVisibilityEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(MessageListVisibilityEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case MessageListVisibilityEnum.HIDE:
                case MessageListVisibilityEnum.SHOW:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of MessageListVisibilityEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of MessageListVisibilityEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<MessageListVisibilityEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into MessageListVisibilityEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed MessageListVisibilityEnum value</returns>
        public static MessageListVisibilityEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type MessageListVisibilityEnum", value));

            return (MessageListVisibilityEnum) index;
        }
    }
} 