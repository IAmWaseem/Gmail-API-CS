/*
 * GmailAPI.Tests
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 01/27/2017
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using GmailAPI.PCL;
using GmailAPI.PCL.Utilities; 
using GmailAPI.PCL.Http.Client;
using GmailAPI.PCL.Http.Response;
using GmailAPI.Tests.Helpers;
using NUnit.Framework;
using GmailAPI.PCL.Controllers;
using GmailAPI.PCL.Models;
using GmailAPI.PCL.Exceptions;

namespace GmailAPI.Tests
{
    [TestFixture]
    public class HistoryControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static HistoryController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().History;
        }

        /// <summary>
        /// Lists the history of all changes to the given mailbox. History results are returned in chronological order (increasing historyId). 
        /// </summary>
        [Test]
        public async Task TestList1() 
        {
            // Parameters for the API call
            string userId = "me";
            string alt = "json";
            string fields = null;
            string key = null;
            string oauthToken = null;
            bool? prettyPrint = true;
            string quotaUser = null;
            string userIp = null;
            string labelId = null;
            double? maxResults = 100;
            string pageToken = null;
            string startHistoryId = null;

            // Perform API call
            ListHistoryResponse result = null;

            try
            {
                result = await controller.ListAsync(userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp, labelId, maxResults, pageToken, startHistoryId);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, httpCallBackHandler.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{  \"history\": [    {      \"labelsAdded\": [        {          \"labelIds\": [],          \"message\": {            \"labelIds\": [],            \"payload\": {              \"body\": {},              \"headers\": [                {}              ],              \"parts\": [                {}              ]            }          }        }      ],      \"labelsRemoved\": [        {          \"labelIds\": [],          \"message\": {            \"labelIds\": [],            \"payload\": {              \"body\": {},              \"headers\": [                {}              ],              \"parts\": [                {}              ]            }          }        }      ],      \"messages\": [        {          \"labelIds\": [],          \"payload\": {            \"body\": {},            \"headers\": [              {}            ],            \"parts\": [              {}            ]          }        }      ],      \"messagesAdded\": [        {          \"message\": {            \"labelIds\": [],            \"payload\": {              \"body\": {},              \"headers\": [                {}              ],              \"parts\": [                {}              ]            }          }        }      ],      \"messagesDeleted\": [        {          \"message\": {            \"labelIds\": [],            \"payload\": {              \"body\": {},              \"headers\": [                {}              ],              \"parts\": [                {}              ]            }          }        }      ]    }  ]}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    false, true, false),
                    "Response body should have matching keys");
        }

    }
}