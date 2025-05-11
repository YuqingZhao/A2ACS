using System.Collections.Generic;
using Newtonsoft.Json;

namespace A2ADotNet.Schema
{
    public class A2ARequest
    {
        public List<OneOf> oneOf { get; set; }
        public string title { get; set; }
    }

    public class AdditionalProperties
    {
    }

    public class AgentAuthentication
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class AgentCapabilities
    {
        public Properties properties { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class AgentCard
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class AgentProvider
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class AgentSkill
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class AnyOf
    {
        public string type { get; set; }

        [JsonProperty("$ref")]
        public string @ref { get; set; }
    }

    public class Append
    {
        public string type { get; set; }
        public string title { get; set; }
    }

    public class Artifact
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Artifact2
    {
        [JsonProperty("$ref")]
        public string @ref { get; set; }
    }

    public class Artifacts
    {
        public Items items { get; set; }
        public string type { get; set; }
        public string title { get; set; }
    }

    public class Authentication
    {
        [JsonProperty("$ref")]
        public string @ref { get; set; }
    }

    public class AuthenticationInfo
    {
        public AdditionalProperties additionalProperties { get; set; }
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Bytes
    {
        public string type { get; set; }
        public string title { get; set; }
    }

    public class CancelTaskRequest
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class CancelTaskResponse
    {
        public Properties properties { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Capabilities
    {
        [JsonProperty("$ref")]
        public string @ref { get; set; }
    }

    public class Code
    {
        public int @const { get; set; }
        public int @default { get; set; }
        public string description { get; set; }
        public List<int> examples { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Credentials
    {
        public string type { get; set; }
        public string title { get; set; }
    }

    public class Data
    {
        public string title { get; set; }
        public AdditionalProperties additionalProperties { get; set; }
        public string type { get; set; }
    }

    public class DataPart
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class DefaultInputModes
    {
        public List<string> @default { get; set; }
        public Items items { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class DefaultOutputModes
    {
        public List<string> @default { get; set; }
        public Items items { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Defs
    {
        public AgentAuthentication AgentAuthentication { get; set; }
        public AgentCapabilities AgentCapabilities { get; set; }
        public AgentCard AgentCard { get; set; }
        public AgentProvider AgentProvider { get; set; }
        public AgentSkill AgentSkill { get; set; }
        public Artifact Artifact { get; set; }
        public AuthenticationInfo AuthenticationInfo { get; set; }
        public PushNotificationNotSupportedError PushNotificationNotSupportedError { get; set; }
        public CancelTaskRequest CancelTaskRequest { get; set; }
        public CancelTaskResponse CancelTaskResponse { get; set; }
        public DataPart DataPart { get; set; }
        public FileContent FileContent { get; set; }
        public FilePart FilePart { get; set; }
        public GetTaskPushNotificationRequest GetTaskPushNotificationRequest { get; set; }
        public GetTaskPushNotificationResponse GetTaskPushNotificationResponse { get; set; }
        public GetTaskRequest GetTaskRequest { get; set; }
        public GetTaskResponse GetTaskResponse { get; set; }
        public InternalError InternalError { get; set; }
        public InvalidParamsError InvalidParamsError { get; set; }
        public InvalidRequestError InvalidRequestError { get; set; }
        public JSONParseError JSONParseError { get; set; }
        public JSONRPCError JSONRPCError { get; set; }
        public JSONRPCMessage JSONRPCMessage { get; set; }
        public JSONRPCRequest JSONRPCRequest { get; set; }
        public JSONRPCResponse JSONRPCResponse { get; set; }
        public Message Message { get; set; }
        public MethodNotFoundError MethodNotFoundError { get; set; }
        public PushNotificationConfig PushNotificationConfig { get; set; }
        public Part Part { get; set; }
        public SendTaskRequest SendTaskRequest { get; set; }
        public SendTaskResponse SendTaskResponse { get; set; }
        public SendTaskStreamingRequest SendTaskStreamingRequest { get; set; }
        public SendTaskStreamingResponse SendTaskStreamingResponse { get; set; }
        public SetTaskPushNotificationRequest SetTaskPushNotificationRequest { get; set; }
        public SetTaskPushNotificationResponse SetTaskPushNotificationResponse { get; set; }
        public Task Task { get; set; }
        public TaskPushNotificationConfig TaskPushNotificationConfig { get; set; }
        public TaskNotCancelableError TaskNotCancelableError { get; set; }
        public TaskNotFoundError TaskNotFoundError { get; set; }
        public TaskIdParams TaskIdParams { get; set; }
        public TaskQueryParams TaskQueryParams { get; set; }
        public TaskSendParams TaskSendParams { get; set; }
        public TaskState TaskState { get; set; }
        public TaskStatus TaskStatus { get; set; }
        public TaskResubscriptionRequest TaskResubscriptionRequest { get; set; }
        public TaskStatusUpdateEvent TaskStatusUpdateEvent { get; set; }
        public TaskArtifactUpdateEvent TaskArtifactUpdateEvent { get; set; }
        public TextPart TextPart { get; set; }
        public UnsupportedOperationError UnsupportedOperationError { get; set; }
        public A2ARequest A2ARequest { get; set; }
    }

    public class Description
    {
        public string type { get; set; }
        public string title { get; set; }
    }

    public class DocumentationUrl
    {
        public string type { get; set; }
        public string title { get; set; }
    }

    public class Error
    {
        [JsonProperty("$ref")]
        public string @ref { get; set; }
    }

    public class Examples
    {
        public Items items { get; set; }
        public string type { get; set; }
        public string title { get; set; }
    }

    public class File
    {
        [JsonProperty("$ref")]
        public string @ref { get; set; }
    }

    public class FileContent
    {
        public Properties properties { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string description { get; set; }
    }

    public class FilePart
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Final
    {
        public bool @default { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class GetTaskPushNotificationRequest
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class GetTaskPushNotificationResponse
    {
        public Properties properties { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class GetTaskRequest
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class GetTaskResponse
    {
        public Properties properties { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class History
    {
        public Items items { get; set; }
        public string type { get; set; }
        public string title { get; set; }
    }

    public class HistoryLength
    {
        public string type { get; set; }
        public string title { get; set; }
    }

    public class Id
    {
        public string title { get; set; }
        public string type { get; set; }
        public List<AnyOf> anyOf { get; set; }
    }

    public class Index
    {
        public string type { get; set; }
        public int @default { get; set; }
        public string title { get; set; }
    }

    public class InputModes
    {
        public Items items { get; set; }
        public string type { get; set; }
        public string title { get; set; }
    }

    public class InternalError
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class InvalidParamsError
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class InvalidRequestError
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Items
    {
        public string type { get; set; }

        [JsonProperty("$ref")]
        public string @ref { get; set; }
    }

    public class JSONParseError
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Jsonrpc
    {
        public string @const { get; set; }
        public string @default { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class JSONRPCError
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class JSONRPCMessage
    {
        public Properties properties { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class JSONRPCRequest
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class JSONRPCResponse
    {
        public Properties properties { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class LastChunk
    {
        public string type { get; set; }
        public string title { get; set; }
    }

    public class Message
    {
        public string @const { get; set; }
        public string @default { get; set; }
        public string description { get; set; }
        public List<string> examples { get; set; }
        public string title { get; set; }
        public string type { get; set; }

        [JsonProperty("$ref")]
        public string @ref { get; set; }
    }

    public class Message7
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Metadata
    {
        public AdditionalProperties additionalProperties { get; set; }
        public string type { get; set; }
        public string title { get; set; }
    }

    public class Method
    {
        public string @const { get; set; }
        public string @default { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class MethodNotFoundError
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class MimeType
    {
        public string type { get; set; }
        public string title { get; set; }
    }

    public class Name
    {
        public string title { get; set; }
        public string type { get; set; }
    }

    public class OneOf
    {
        [JsonProperty("$ref")]
        public string @ref { get; set; }
    }

    public class Organization
    {
        public string title { get; set; }
        public string type { get; set; }
    }

    public class OutputModes
    {
        public Items items { get; set; }
        public string type { get; set; }
        public string title { get; set; }
    }

    public class Params
    {
        [JsonProperty("$ref")]
        public string @ref { get; set; }
        public AdditionalProperties additionalProperties { get; set; }
        public string type { get; set; }
        public string title { get; set; }
    }

    public class Part
    {
        public List<AnyOf> anyOf { get; set; }
        public string title { get; set; }
    }

    public class Parts
    {
        public Items items { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Properties
    {
        public Schemes schemes { get; set; }
        public Credentials credentials { get; set; }
        public Jsonrpc jsonrpc { get; set; }
        public Id id { get; set; }
        public Result result { get; set; }
        public Error error { get; set; }
        public Type type { get; set; }
        public Data data { get; set; }
        public Metadata metadata { get; set; }
        public Name name { get; set; }
        public MimeType mimeType { get; set; }
        public Bytes bytes { get; set; }
        public Uri uri { get; set; }
        public File file { get; set; }
        public Method method { get; set; }
        public Params @params { get; set; }
        public Code code { get; set; }
        public Message message { get; set; }
        public Streaming streaming { get; set; }
        public PushNotifications pushNotifications { get; set; }
        public StateTransitionHistory stateTransitionHistory { get; set; }
        public Role role { get; set; }
        public Parts parts { get; set; }
        public Url url { get; set; }
        public Token token { get; set; }
        public Authentication authentication { get; set; }
        public Description description { get; set; }
        public Provider provider { get; set; }
        public Version version { get; set; }
        public DocumentationUrl documentationUrl { get; set; }
        public Capabilities capabilities { get; set; }
        public DefaultInputModes defaultInputModes { get; set; }
        public DefaultOutputModes defaultOutputModes { get; set; }
        public Skills skills { get; set; }
        public SessionId sessionId { get; set; }
        public Status status { get; set; }
        public Artifacts artifacts { get; set; }
        public History history { get; set; }
        public PushNotificationConfig pushNotificationConfig { get; set; }
        public Organization organization { get; set; }
        public HistoryLength historyLength { get; set; }
        public PushNotification pushNotification { get; set; }
        public State state { get; set; }
        public Timestamp timestamp { get; set; }
        public Final final { get; set; }
        public Artifact artifact { get; set; }
        public Text text { get; set; }
        public Tags tags { get; set; }
        public Examples examples { get; set; }
        public InputModes inputModes { get; set; }
        public OutputModes outputModes { get; set; }
        public Index index { get; set; }
        public Append append { get; set; }
        public LastChunk lastChunk { get; set; }
    }

    public class Provider
    {
        [JsonProperty("$ref")]
        public string @ref { get; set; }
    }

    public class PushNotification
    {
        [JsonProperty("$ref")]
        public string @ref { get; set; }
    }

    public class PushNotificationConfig
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class PushNotificationConfig2
    {
        [JsonProperty("$ref")]
        public string @ref { get; set; }
    }

    public class PushNotificationNotSupportedError
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class PushNotifications
    {
        public bool @default { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Result
    {
        [JsonProperty("$ref")]
        public string @ref { get; set; }
        public AdditionalProperties additionalProperties { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public List<AnyOf> anyOf { get; set; }
    }

    public class Role
    {
        public List<string> @enum { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Root
    {
        [JsonProperty("$schema")]
        public string schema { get; set; }
        public string title { get; set; }
        public string description { get; set; }

        [JsonProperty("$defs")]
        public Defs defs { get; set; }
    }

    public class Schemes
    {
        public Items items { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class SendTaskRequest
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class SendTaskResponse
    {
        public Properties properties { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class SendTaskStreamingRequest
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class SendTaskStreamingResponse
    {
        public Properties properties { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class SessionId
    {
        public string type { get; set; }
        public string title { get; set; }
    }

    public class SetTaskPushNotificationRequest
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class SetTaskPushNotificationResponse
    {
        public Properties properties { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Skills
    {
        public Items items { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class State
    {
        [JsonProperty("$ref")]
        public string @ref { get; set; }
    }

    public class StateTransitionHistory
    {
        public bool @default { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Status
    {
        [JsonProperty("$ref")]
        public string @ref { get; set; }
    }

    public class Streaming
    {
        public bool @default { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Tags
    {
        public Items items { get; set; }
        public string type { get; set; }
        public string title { get; set; }
    }

    public class Task
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class TaskArtifactUpdateEvent
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class TaskIdParams
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class TaskNotCancelableError
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class TaskNotFoundError
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class TaskPushNotificationConfig
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class TaskQueryParams
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class TaskResubscriptionRequest
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class TaskSendParams
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class TaskState
    {
        public string description { get; set; }
        public List<string> @enum { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class TaskStatus
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class TaskStatusUpdateEvent
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Text
    {
        public string title { get; set; }
        public string type { get; set; }
    }

    public class TextPart
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Timestamp
    {
        public string format { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Token
    {
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Type
    {
        public string @const { get; set; }
        public string @default { get; set; }
        public string description { get; set; }
        public List<string> examples { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class UnsupportedOperationError
    {
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Uri
    {
        public string type { get; set; }
        public string title { get; set; }
    }

    public class Url
    {
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Version
    {
        public string title { get; set; }
        public string type { get; set; }
    }


}
