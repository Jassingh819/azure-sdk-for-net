# Create Call

This sample demonstrates how to make a call to a recipient phone number.

To get started you'll need a Communication Service Resource.  See [README][README] for prerequisites and instructions.

## Creating a `CallingServerClient`

CallingServer client can be authenticated using the connection string acquired from an Azure Communication Resource in the Azure Portal.

```C#
var connectionString = "<connection_string>"; // Find your Communication Services resource in the Azure portal
CallingServerClient callingServerClient = new CallingServerClient(connectionString);
```

## Make a call to a phone number recipient

To make a Call, call the `CreateCall` or `CreateCallAsync` function from the `CallClient`. The returned value is `CreateCallResponse` objects that contains the created Call's Id if succeed, else throws a RequestFailedException.
```C#
var createCallOption = new CreateCallOptions(
       AlternateCallerId: new PhoneNumberIdentifier("<caller-id-phonenumber>") // E.164 formatted recipient phone number
       );
```
```C
var callConnection = await callingServerClient.CreateCallAsync(
    source: new CommunicationUserIdentifier("<source-identifier>"), // Your Azure Communication Resource Guid Id used to make a Call
    targets: new List<CommunicationIdentifier>() { new PhoneNumberIdentifier("<targets-phone-number>") }, // E.164 formatted recipient phone number
    callbackEndpoint: new Uri(TestEnvironment.AppCallbackUrl),
    options: createCallOption // The options for creating a call.
    );
Console.WriteLine($"Call connection id: {callConnection.Value.CallConnectionId}");
```

To see the full example source files, see:

* [Make a call to a phone number recipient](https://github.com/Azure/azure-sdk-for-net/blob/a20e269162fa88a43e5ba0e5bb28f2e76c74a484/sdk/communication/Azure.Communication.CallingServer/tests/samples/Sample1_CallClient.cs)

[README]: https://github.com/Azure/azure-sdk-for-net/blob/a20e269162fa88a43e5ba0e5bb28f2e76c74a484/sdk/communication/Azure.Communication.CallingServer/README.md#getting-started
