/*
 * GmailAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 01/27/2017
 */
using System;
using GmailAPI.PCL.Controllers;
using GmailAPI.PCL.Http.Client;

namespace GmailAPI.PCL
{
    public partial class GmailAPIClient
    {

        /// <summary>
        /// Singleton access to Users controller
        /// </summary>
        public UsersController Users
        {
            get
            {
                return UsersController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Threads controller
        /// </summary>
        public ThreadsController Threads
        {
            get
            {
                return ThreadsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Messages controller
        /// </summary>
        public MessagesController Messages
        {
            get
            {
                return MessagesController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Attachments controller
        /// </summary>
        public AttachmentsController Attachments
        {
            get
            {
                return AttachmentsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Labels controller
        /// </summary>
        public LabelsController Labels
        {
            get
            {
                return LabelsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to History controller
        /// </summary>
        public HistoryController History
        {
            get
            {
                return HistoryController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Drafts controller
        /// </summary>
        public DraftsController Drafts
        {
            get
            {
                return DraftsController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public GmailAPIClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public GmailAPIClient(string oAuthAccessToken)
        {
            Configuration.OAuthAccessToken = oAuthAccessToken;
        }
    }
}