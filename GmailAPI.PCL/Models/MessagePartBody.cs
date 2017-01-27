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
    public class MessagePartBody : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string attachmentId;
        private string data;
        private double? size;

        /// <summary>
        /// When present, contains the ID of an external attachment that can be retrieved in a separate messages.attachments.get request. When not present, the entire content of the message part body is contained in the data field.
        /// </summary>
        [JsonProperty("attachmentId")]
        public string AttachmentId 
        { 
            get 
            {
                return this.attachmentId; 
            } 
            set 
            {
                this.attachmentId = value;
                onPropertyChanged("AttachmentId");
            }
        }

        /// <summary>
        /// The body data of a MIME message part. May be empty for MIME container types that have no message body or when the body data is sent as a separate attachment. An attachment ID is present if the body data is contained in a separate attachment.
        /// </summary>
        [JsonProperty("data")]
        public string Data 
        { 
            get 
            {
                return this.data; 
            } 
            set 
            {
                this.data = value;
                onPropertyChanged("Data");
            }
        }

        /// <summary>
        /// Total number of bytes in the body of the message part.
        /// </summary>
        [JsonProperty("size")]
        public double? Size 
        { 
            get 
            {
                return this.size; 
            } 
            set 
            {
                this.size = value;
                onPropertyChanged("Size");
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