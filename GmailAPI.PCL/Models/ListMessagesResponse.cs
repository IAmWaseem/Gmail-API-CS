/*
 * GmailAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 01/27/2017
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using GmailAPI.PCL;
using GmailAPI.PCL.Utilities;

namespace GmailAPI.PCL.Models
{
    public class ListMessagesResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private List<Message> messages;
        private string nextPageToken;
        private double? resultSizeEstimate;

        /// <summary>
        /// List of messages.
        /// </summary>
        [JsonProperty("messages")]
        public List<Message> Messages 
        { 
            get 
            {
                return this.messages; 
            } 
            set 
            {
                this.messages = value;
                onPropertyChanged("Messages");
            }
        }

        /// <summary>
        /// Token to retrieve the next page of results in the list.
        /// </summary>
        [JsonProperty("nextPageToken")]
        public string NextPageToken 
        { 
            get 
            {
                return this.nextPageToken; 
            } 
            set 
            {
                this.nextPageToken = value;
                onPropertyChanged("NextPageToken");
            }
        }

        /// <summary>
        /// Estimated total number of results.
        /// </summary>
        [JsonProperty("resultSizeEstimate")]
        public double? ResultSizeEstimate 
        { 
            get 
            {
                return this.resultSizeEstimate; 
            } 
            set 
            {
                this.resultSizeEstimate = value;
                onPropertyChanged("ResultSizeEstimate");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 