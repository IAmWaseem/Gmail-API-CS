# Getting started

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (GmailAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Gmail%20API-CSharp&workspaceName=GmailAPI&projectName=GmailAPI.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the GmailAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Gmail%20API-CSharp&workspaceName=GmailAPI&projectName=GmailAPI.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Gmail%20API-CSharp&workspaceName=GmailAPI&projectName=GmailAPI.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Gmail%20API-CSharp&workspaceName=GmailAPI&projectName=GmailAPI.PCL)

### 3. Add reference of the library project

In order to use the GmailAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Gmail%20API-CSharp&workspaceName=GmailAPI&projectName=GmailAPI.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` GmailAPI.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```GmailAPI.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Gmail%20API-CSharp&workspaceName=GmailAPI&projectName=GmailAPI.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Gmail%20API-CSharp&workspaceName=GmailAPI&projectName=GmailAPI.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| oAuthAccessToken | The OAuth 2.0 access token to be set before API calls |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string oAuthAccessToken = "oAuthAccessToken"; // The OAuth 2.0 access token to be set before API calls

GmailAPIClient client = new GmailAPIClient(oAuthAccessToken);
```

## Class Reference

### <a name="list_of_controllers"></a>List of Controllers

* [UsersController](#users_controller)
* [ThreadsController](#threads_controller)
* [MessagesController](#messages_controller)
* [AttachmentsController](#attachments_controller)
* [LabelsController](#labels_controller)
* [HistoryController](#history_controller)
* [DraftsController](#drafts_controller)

### <a name="users_controller"></a>![Class: ](https://apidocs.io/img/class.png "GmailAPI.PCL.Controllers.UsersController") UsersController

#### Get singleton instance

The singleton instance of the ``` UsersController ``` class can be accessed from the API Client.

```csharp
UsersController users = client.Users;
```

#### <a name="create_watch"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.UsersController.CreateWatch") CreateWatch

> Set up or update a push notification watch on the given user mailbox.


```csharp
Task<WatchResponse> CreateWatch(
        WatchRequest body,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string bodyValue = "{  \"labelFilterAction\": \"exclude\",  \"labelIds\": []}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<WatchRequest>(bodyValue);
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

WatchResponse result = await users.CreateWatch(body, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


#### <a name="create_stop"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.UsersController.CreateStop") CreateStop

> Stop receiving push notifications for the given user mailbox.


```csharp
Task CreateStop(
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

await users.CreateStop(userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


#### <a name="get_profile"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.UsersController.GetProfile") GetProfile

> Gets the current user's Gmail profile.


```csharp
Task<Profile> GetProfile(
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

Profile result = await users.GetProfile(userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="threads_controller"></a>![Class: ](https://apidocs.io/img/class.png "GmailAPI.PCL.Controllers.ThreadsController") ThreadsController

#### Get singleton instance

The singleton instance of the ``` ThreadsController ``` class can be accessed from the API Client.

```csharp
ThreadsController threads = client.Threads;
```

#### <a name="create_untrash"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.ThreadsController.CreateUntrash") CreateUntrash

> Removes the specified thread from the trash.


```csharp
Task<Thread> CreateUntrash(
        string id,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The ID of the thread to remove from Trash. |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string id = "id";
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

Thread result = await threads.CreateUntrash(id, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


#### <a name="create_trash"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.ThreadsController.CreateTrash") CreateTrash

> Moves the specified thread to the trash.


```csharp
Task<Thread> CreateTrash(
        string id,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The ID of the thread to Trash. |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string id = "id";
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

Thread result = await threads.CreateTrash(id, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


#### <a name="modify"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.ThreadsController.Modify") Modify

> Modifies the labels applied to the thread. This applies to all messages in the thread.


```csharp
Task<Thread> Modify(
        string id,
        ModifyThreadRequest body,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The ID of the thread to modify. |
| body |  ``` Required ```  | TODO: Add a parameter description |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string id = "id";
var body = new ModifyThreadRequest();
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

Thread result = await threads.Modify(id, body, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


#### <a name="list"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.ThreadsController.List") List

> Lists the threads in the user's mailbox.


```csharp
Task<ListThreadsResponse> List(
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null,
        bool? includeSpamTrash = false,
        string labelIds = null,
        double? maxResults = 100,
        string pageToken = null,
        string q = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |
| includeSpamTrash |  ``` Optional ```  ``` DefaultValue ```  | Include threads from SPAM and TRASH in the results. |
| labelIds |  ``` Optional ```  | Only return threads with labels that match all of the specified label IDs. |
| maxResults |  ``` Optional ```  ``` DefaultValue ```  | Maximum number of threads to return. |
| pageToken |  ``` Optional ```  | Page token to retrieve a specific page of results in the list. |
| q |  ``` Optional ```  | Only return threads matching the specified query. Supports the same query format as the Gmail search box. For example, "from:someuser@example.com rfc822msgid: is:unread". |


#### Example Usage

```csharp
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";
bool? includeSpamTrash = false;
string labelIds = "labelIds";
double? maxResults = 100;
string pageToken = "pageToken";
string q = "q";

ListThreadsResponse result = await threads.List(userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp, includeSpamTrash, labelIds, maxResults, pageToken, q);

```


#### <a name="get_threads_by_user_id_and_id"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.ThreadsController.GetThreadsByUserIdAndId") GetThreadsByUserIdAndId

> Gets the specified thread.


```csharp
Task<Thread> GetThreadsByUserIdAndId(
        string id,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null,
        string format = "full",
        string metadataHeaders = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The ID of the thread to retrieve. |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |
| format |  ``` Optional ```  ``` DefaultValue ```  | The format to return the messages in. (Acceptable values are: "full", "metadata", "minimal") |
| metadataHeaders |  ``` Optional ```  | When given and format is METADATA, only include headers specified. |


#### Example Usage

```csharp
string id = "id";
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";
string format = "full";
string metadataHeaders = "metadataHeaders";

Thread result = await threads.GetThreadsByUserIdAndId(id, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp, format, metadataHeaders);

```


#### <a name="delete_threads_by_user_id_and_id"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.ThreadsController.DeleteThreadsByUserIdAndId") DeleteThreadsByUserIdAndId

> Immediately and permanently deletes the specified thread. This operation cannot be undone. Prefer threads.trash instead.


```csharp
Task DeleteThreadsByUserIdAndId(
        string id,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | ID of the Thread to delete. |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string id = "id";
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

await threads.DeleteThreadsByUserIdAndId(id, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="messages_controller"></a>![Class: ](https://apidocs.io/img/class.png "GmailAPI.PCL.Controllers.MessagesController") MessagesController

#### Get singleton instance

The singleton instance of the ``` MessagesController ``` class can be accessed from the API Client.

```csharp
MessagesController messages = client.Messages;
```

#### <a name="create_untrash"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.MessagesController.CreateUntrash") CreateUntrash

> Removes the specified message from the trash.


```csharp
Task<Message> CreateUntrash(
        string id,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The ID of the message to remove from Trash. |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string id = "id";
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

Message result = await messages.CreateUntrash(id, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


#### <a name="create_trash"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.MessagesController.CreateTrash") CreateTrash

> Moves the specified message to the trash.


```csharp
Task<Message> CreateTrash(
        string id,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The ID of the message to Trash. |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string id = "id";
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

Message result = await messages.CreateTrash(id, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


#### <a name="create_send"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.MessagesController.CreateSend") CreateSend

> Sends the specified message to the recipients in the To, Cc, and Bcc headers.


```csharp
Task<Message> CreateSend(
        Message body,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string bodyValue = "{  \"labelIds\": [],  \"payload\": {    \"body\": {},    \"headers\": [      {}    ],    \"parts\": [      {}    ]  }}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Message>(bodyValue);
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

Message result = await messages.CreateSend(body, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


#### <a name="modify"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.MessagesController.Modify") Modify

> Modifies the labels on the specified message.


```csharp
Task<Message> Modify(
        string id,
        ModifyMessageRequest body,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The ID of the message to modify. |
| body |  ``` Required ```  | TODO: Add a parameter description |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string id = "id";
var body = new ModifyMessageRequest();
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

Message result = await messages.Modify(id, body, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


#### <a name="insert"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.MessagesController.Insert") Insert

> Directly inserts a message into only this user's mailbox similar to IMAP APPEND, bypassing most scanning and classification. Does not send a message.


```csharp
Task<Message> Insert(
        Message body,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null,
        bool? deleted = false,
        string internalDateSource = "receivedTime")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |
| deleted |  ``` Optional ```  ``` DefaultValue ```  | Mark the email as permanently deleted (not TRASH) and only visible in Google Apps Vault to a Vault administrator. Only used for Google Apps for Work accounts. |
| internalDateSource |  ``` Optional ```  ``` DefaultValue ```  | Source for Gmail's internal date of the message. (Acceptable values are: "dateHeader", "receivedTime") |


#### Example Usage

```csharp
string bodyValue = "{  \"labelIds\": [],  \"payload\": {    \"body\": {},    \"headers\": [      {}    ],    \"parts\": [      {}    ]  }}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Message>(bodyValue);
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";
bool? deleted = false;
string internalDateSource = "receivedTime";

Message result = await messages.Insert(body, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp, deleted, internalDateSource);

```


#### <a name="get_messages_by_user_id_and_id"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.MessagesController.GetMessagesByUserIdAndId") GetMessagesByUserIdAndId

> Gets the specified message.


```csharp
Task<Message> GetMessagesByUserIdAndId(
        string id,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null,
        string format = "full",
        string metadataHeaders = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The ID of the message to retrieve. |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |
| format |  ``` Optional ```  ``` DefaultValue ```  | The format to return the message in. (Acceptable values are: "full", "metadata", "minimal", "raw") |
| metadataHeaders |  ``` Optional ```  | When given and format is METADATA, only include headers specified. |


#### Example Usage

```csharp
string id = "id";
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";
string format = "full";
string metadataHeaders = "metadataHeaders";

Message result = await messages.GetMessagesByUserIdAndId(id, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp, format, metadataHeaders);

```


#### <a name="delete_messages_by_user_id_and_id"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.MessagesController.DeleteMessagesByUserIdAndId") DeleteMessagesByUserIdAndId

> Immediately and permanently deletes the specified message. This operation cannot be undone. Prefer messages.trash instead.


```csharp
Task DeleteMessagesByUserIdAndId(
        string id,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The ID of the message to delete. |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string id = "id";
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

await messages.DeleteMessagesByUserIdAndId(id, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


#### <a name="list"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.MessagesController.List") List

> Lists the messages in the user's mailbox.


```csharp
Task<ListMessagesResponse> List(
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null,
        bool? includeSpamTrash = false,
        string labelIds = null,
        double? maxResults = 100,
        string pageToken = null,
        string q = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |
| includeSpamTrash |  ``` Optional ```  ``` DefaultValue ```  | Include messages from SPAM and TRASH in the results. |
| labelIds |  ``` Optional ```  | Only return messages with labels that match all of the specified label IDs. |
| maxResults |  ``` Optional ```  ``` DefaultValue ```  | Maximum number of messages to return. |
| pageToken |  ``` Optional ```  | Page token to retrieve a specific page of results in the list. |
| q |  ``` Optional ```  | Only return messages matching the specified query. Supports the same query format as the Gmail search box. For example, "from:someuser@example.com rfc822msgid: is:unread". |


#### Example Usage

```csharp
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";
bool? includeSpamTrash = false;
string labelIds = "labelIds";
double? maxResults = 100;
string pageToken = "pageToken";
string q = "q";

ListMessagesResponse result = await messages.List(userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp, includeSpamTrash, labelIds, maxResults, pageToken, q);

```


#### <a name="create_import"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.MessagesController.CreateImport") CreateImport

> Imports a message into only this user's mailbox, with standard email delivery scanning and classification similar to receiving via SMTP. Does not send a message.


```csharp
Task<Message> CreateImport(
        Message body,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null,
        bool? deleted = false,
        string internalDateSource = "dateHeader",
        bool? neverMarkSpam = false,
        bool? processForCalendar = false)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |
| deleted |  ``` Optional ```  ``` DefaultValue ```  | Mark the email as permanently deleted (not TRASH) and only visible in Google Apps Vault to a Vault administrator. Only used for Google Apps for Work accounts. |
| internalDateSource |  ``` Optional ```  ``` DefaultValue ```  | Source for Gmail's internal date of the message. (Acceptable values are: "dateHeader", "receivedTime") |
| neverMarkSpam |  ``` Optional ```  ``` DefaultValue ```  | Ignore the Gmail spam classifier decision and never mark this email as SPAM in the mailbox. |
| processForCalendar |  ``` Optional ```  ``` DefaultValue ```  | Process calendar invites in the email and add any extracted meetings to the Google Calendar for this user. |


#### Example Usage

```csharp
string bodyValue = "{  \"labelIds\": [],  \"payload\": {    \"body\": {},    \"headers\": [      {}    ],    \"parts\": [      {}    ]  }}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Message>(bodyValue);
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";
bool? deleted = false;
string internalDateSource = "dateHeader";
bool? neverMarkSpam = false;
bool? processForCalendar = false;

Message result = await messages.CreateImport(body, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp, deleted, internalDateSource, neverMarkSpam, processForCalendar);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="attachments_controller"></a>![Class: ](https://apidocs.io/img/class.png "GmailAPI.PCL.Controllers.AttachmentsController") AttachmentsController

#### Get singleton instance

The singleton instance of the ``` AttachmentsController ``` class can be accessed from the API Client.

```csharp
AttachmentsController attachments = client.Attachments;
```

#### <a name="get_messages_attachments_id_by_user_id"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.AttachmentsController.GetMessagesAttachmentsIdByUserId") GetMessagesAttachmentsIdByUserId

> Gets the specified message attachment.


```csharp
Task<MessagePartBody> GetMessagesAttachmentsIdByUserId(
        string id,
        string messageId,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The ID of the attachment. |
| messageId |  ``` Required ```  | The ID of the message containing the attachment. |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string id = "id";
string messageId = "messageId";
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

MessagePartBody result = await attachments.GetMessagesAttachmentsIdByUserId(id, messageId, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="labels_controller"></a>![Class: ](https://apidocs.io/img/class.png "GmailAPI.PCL.Controllers.LabelsController") LabelsController

#### Get singleton instance

The singleton instance of the ``` LabelsController ``` class can be accessed from the API Client.

```csharp
LabelsController labels = client.Labels;
```

#### <a name="update"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.LabelsController.Update") Update

> Updates the specified label.


```csharp
Task<Label> Update(
        string id,
        Label body,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The ID of the label to update. |
| body |  ``` Required ```  | TODO: Add a parameter description |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string id = "id";
var body = new Label();
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

Label result = await labels.Update(id, body, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


#### <a name="patch_labels_by_user_id_and_id"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.LabelsController.PatchLabelsByUserIdAndId") PatchLabelsByUserIdAndId

> Updates the specified label. This method supports patch semantics.


```csharp
Task<Label> PatchLabelsByUserIdAndId(
        string id,
        Label body,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The ID of the label to update. |
| body |  ``` Required ```  | TODO: Add a parameter description |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string id = "id";
var body = new Label();
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

Label result = await labels.PatchLabelsByUserIdAndId(id, body, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


#### <a name="get_labels_by_user_id_and_id"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.LabelsController.GetLabelsByUserIdAndId") GetLabelsByUserIdAndId

> Gets the specified label.


```csharp
Task<Label> GetLabelsByUserIdAndId(
        string id,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The ID of the label to update. |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string id = "id";
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

Label result = await labels.GetLabelsByUserIdAndId(id, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


#### <a name="delete_labels_by_user_id_and_id"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.LabelsController.DeleteLabelsByUserIdAndId") DeleteLabelsByUserIdAndId

> Immediately and permanently deletes the specified label and removes it from any messages and threads that it is applied to.


```csharp
Task DeleteLabelsByUserIdAndId(
        string id,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The ID of the label to update. |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string id = "id";
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

await labels.DeleteLabelsByUserIdAndId(id, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


#### <a name="list"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.LabelsController.List") List

> Lists all labels in the user's mailbox.


```csharp
Task<ListLabelsResponse> List(
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

ListLabelsResponse result = await labels.List(userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


#### <a name="create"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.LabelsController.Create") Create

> Creates a new label.


```csharp
Task<Label> Create(
        Label body,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string bodyValue = "{  \"labelListVisibility\": \"labelHide\",  \"messageListVisibility\": \"hide\",  \"type\": \"system\"}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Label>(bodyValue);
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

Label result = await labels.Create(body, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="history_controller"></a>![Class: ](https://apidocs.io/img/class.png "GmailAPI.PCL.Controllers.HistoryController") HistoryController

#### Get singleton instance

The singleton instance of the ``` HistoryController ``` class can be accessed from the API Client.

```csharp
HistoryController history = client.History;
```

#### <a name="list"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.HistoryController.List") List

> Lists the history of all changes to the given mailbox. History results are returned in chronological order (increasing historyId).


```csharp
Task<ListHistoryResponse> List(
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null,
        string labelId = null,
        double? maxResults = 100,
        string pageToken = null,
        string startHistoryId = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |
| labelId |  ``` Optional ```  | Only return messages with a label matching the ID. |
| maxResults |  ``` Optional ```  ``` DefaultValue ```  | The maximum number of history records to return. |
| pageToken |  ``` Optional ```  | Page token to retrieve a specific page of results in the list. |
| startHistoryId |  ``` Optional ```  | Required. Returns history records after the specified startHistoryId. The supplied startHistoryId should be obtained from the historyId of a message, thread, or previous list response. History IDs increase chronologically but are not contiguous with random gaps in between valid IDs. Supplying an invalid or out of date startHistoryId typically returns an HTTP 404 error code. A historyId is typically valid for at least a week, but in some rare circumstances may be valid for only a few hours. If you receive an HTTP 404 error response, your application should perform a full sync. If you receive no nextPageToken in the response, there are no updates to retrieve and you can store the returned historyId for a future request. |


#### Example Usage

```csharp
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";
string labelId = "labelId";
double? maxResults = 100;
string pageToken = "pageToken";
string startHistoryId = "startHistoryId";

ListHistoryResponse result = await history.List(userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp, labelId, maxResults, pageToken, startHistoryId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="drafts_controller"></a>![Class: ](https://apidocs.io/img/class.png "GmailAPI.PCL.Controllers.DraftsController") DraftsController

#### Get singleton instance

The singleton instance of the ``` DraftsController ``` class can be accessed from the API Client.

```csharp
DraftsController drafts = client.Drafts;
```

#### <a name="update"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.DraftsController.Update") Update

> Replaces a draft's content.


```csharp
Task<Draft> Update(
        string id,
        Draft body,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The ID of the draft to update. |
| body |  ``` Required ```  | TODO: Add a parameter description |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string id = "id";
var body = new Draft();
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

Draft result = await drafts.Update(id, body, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


#### <a name="delete_drafts_by_user_id_and_id"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.DraftsController.DeleteDraftsByUserIdAndId") DeleteDraftsByUserIdAndId

> Immediately and permanently deletes the specified draft. Does not simply trash it.


```csharp
Task DeleteDraftsByUserIdAndId(
        string id,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The ID of the draft to update. |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string id = "id";
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

await drafts.DeleteDraftsByUserIdAndId(id, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


#### <a name="create_send"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.DraftsController.CreateSend") CreateSend

> Sends the specified, existing draft to the recipients in the To, Cc, and Bcc headers.


```csharp
Task<Message> CreateSend(
        Draft body,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string bodyValue = "{  \"message\": {    \"labelIds\": [],    \"payload\": {      \"body\": {},      \"headers\": [        {}      ],      \"parts\": [        {}      ]    }  }}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Draft>(bodyValue);
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

Message result = await drafts.CreateSend(body, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


#### <a name="list"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.DraftsController.List") List

> Lists the drafts in the user's mailbox.


```csharp
Task<ListDraftsResponse> List(
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null,
        double? maxResults = 100,
        string pageToken = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |
| maxResults |  ``` Optional ```  ``` DefaultValue ```  | Maximum number of drafts to return. |
| pageToken |  ``` Optional ```  | Page token to retrieve a specific page of results in the list. |


#### Example Usage

```csharp
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";
double? maxResults = 100;
string pageToken = "pageToken";

ListDraftsResponse result = await drafts.List(userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp, maxResults, pageToken);

```


#### <a name="get_drafts_by_user_id_and_id"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.DraftsController.GetDraftsByUserIdAndId") GetDraftsByUserIdAndId

> Gets the specified draft.


```csharp
Task<Draft> GetDraftsByUserIdAndId(
        string id,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null,
        string format = "full")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | The ID of the draft to retrieve. |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |
| format |  ``` Optional ```  ``` DefaultValue ```  | The format to return the draft in. (Acceptable values are: "full", "metadata", "minimal", "raw") |


#### Example Usage

```csharp
string id = "id";
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";
string format = "full";

Draft result = await drafts.GetDraftsByUserIdAndId(id, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp, format);

```


#### <a name="create"></a>![Method: ](https://apidocs.io/img/method.png "GmailAPI.PCL.Controllers.DraftsController.Create") Create

> Creates a new draft with the DRAFT label.


```csharp
Task<Draft> Create(
        Draft body,
        string userId = "me",
        string alt = "json",
        string fields = null,
        string key = null,
        string oauthToken = null,
        bool? prettyPrint = true,
        string quotaUser = null,
        string userIp = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |
| userId |  ``` Optional ```  ``` DefaultValue ```  | The user's email address. The special value me can be used to indicate the authenticated user. |
| alt |  ``` Optional ```  ``` DefaultValue ```  | Data format for the response. (Acceptable values are: "json") |
| fields |  ``` Optional ```  | Selector specifying which fields to include in a partial response. |
| key |  ``` Optional ```  | API key. Your API key identifies your project and provides you with API access, quota, and reports. Required unless you provide an OAuth 2.0 token. |
| oauthToken |  ``` Optional ```  | OAuth 2.0 token for the current user. |
| prettyPrint |  ``` Optional ```  ``` DefaultValue ```  | Returns response with indentations and line breaks. |
| quotaUser |  ``` Optional ```  | Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided. |
| userIp |  ``` Optional ```  | IP address of the site where the request originates. Use this if you want to enforce per-user limits. |


#### Example Usage

```csharp
string bodyValue = "{  \"message\": {    \"labelIds\": [],    \"payload\": {      \"body\": {},      \"headers\": [        {}      ],      \"parts\": [        {}      ]    }  }}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Draft>(bodyValue);
string userId = "me";
string alt = "json";
string fields = "fields";
string key = "key";
string oauthToken = "oauth_token";
bool? prettyPrint = true;
string quotaUser = "quotaUser";
string userIp = "userIp";

Draft result = await drafts.Create(body, userId, alt, fields, key, oauthToken, prettyPrint, quotaUser, userIp);

```


[Back to List of Controllers](#list_of_controllers)



