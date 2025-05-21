using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace A2ADotNet.Schema
{
    public class AgentCard
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("description")]
        public string Description;

        [JsonProperty("url")]
        public string Url;

        [JsonProperty("provider")]
        public ProviderInfo Provider;

        [JsonProperty("version")]
        public string Version;

        [JsonProperty("documentationUrl")]
        public string DocumentationUrl;

        [JsonProperty("capabilities")]
        public CapabilitiesInfo Capabilities;

        [JsonProperty("securitySchemes")]
        public Dictionary<string, SecurityScheme> SecuritySchemes;

        [JsonProperty("security")]
        public List<Dictionary<string, List<string>>> Security;

        [JsonProperty("defaultInputModes")]
        public List<string> DefaultInputModes;

        [JsonProperty("defaultOutputModes")]
        public List<string> DefaultOutputModes;

        [JsonProperty("skills")]
        public List<SkillInfo> Skills;
    }

    public class ProviderInfo
    {
        [JsonProperty("organization")]
        public string Organization;

        [JsonProperty("url")]
        public string Url;
    }

    public class CapabilitiesInfo
    {
        [JsonProperty("streaming")]
        public bool Streaming;

        [JsonProperty("pushNotifications")]
        public bool PushNotifications;

        [JsonProperty("stateTransitionHistory")]
        public bool StateTransitionHistory;
    }

    public class SecurityScheme
    {
        [JsonProperty("type")]
        public string Type;

        [JsonProperty("openIdConnectUrl")]
        public string OpenIdConnectUrl;
    }

    public class SkillInfo
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("description")]
        public string Description;

        [JsonProperty("tags")]
        public List<string> Tags;

        [JsonProperty("examples")]
        public List<string> Examples;

        [JsonProperty("inputModes")]
        public List<string> InputModes;

        [JsonProperty("outputModes")]
        public List<string> OutputModes;
    }

    public class AgentAuthentication
    {
        [JsonProperty("schemes")]
        public List<string> Schemes { get; set; }

        [JsonProperty("credentials")]
        public string Credentials { get; set; }
    }

    public class AgentCapabilities
    {
        [JsonProperty("streaming")]
        public bool Streaming { get; set; }

        [JsonProperty("pushNotifications")]
        public bool PushNotifications { get; set; }

        [JsonProperty("stateTransitionHistory")]
        public bool StateTransitionHistory { get; set; }
    }

    public class AgentProvider
    {
        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AgentSkill
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("examples")]
        public List<string> Examples { get; set; }

        [JsonProperty("inputModes")]
        public List<string> InputModes { get; set; }

        [JsonProperty("outputModes")]
        public List<string> OutputModes { get; set; }
    }

    // --- Parts ---
    public class Part
    {
        [JsonProperty("kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PartKindEnum Kind { get; set; }
    }

    public enum PartKindEnum
    {
        Text,
        File,
        Data,
    }

    public class TextPart : Part
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, object> Metadata { get; set; } = new Dictionary<string, object>();
    }

    public class FilePart : Part
    {
        [JsonProperty("file")]
        public FileContent File { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, object> Metadata { get; set; } = new Dictionary<string, object>();
    }

    public class DataPart : Part
    {
        [JsonProperty("data")]
        public Dictionary<string, object> Data { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, object> Metadata { get; set; } = new Dictionary<string, object>();
    }

    // --- FileContent ---
    public class FileContent
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("bytes")]
        public string Bytes { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    // --- Artifact ---
    public class Artifact
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("parts")]
        public List<Part> Parts { get; set; }

        [JsonProperty("index")]
        public int? Index { get; set; }

        [JsonProperty("append")]
        public bool? Append { get; set; }

        [JsonProperty("lastChunk")]
        public bool? LastChunk { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, object> Metadata { get; set; }
    }

    // --- Message ---
    public class Message
    {
        [JsonProperty("role")]
        public string Role { get; set; } // "user" or "agent"

        [JsonProperty("parts")]
        public List<object> Parts { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, object> Metadata { get; set; } = new Dictionary<string, object>();

        [JsonProperty("kind")]
        public string Kind { get; set; } = "message";

        [JsonProperty("messageId")]
        public string MessageId { get; set; }
    }

    // --- TaskState Enum ---
    public static class TaskStates
    {
        public const string Submitted = "submitted";
        public const string Working = "working";
        public const string InputRequired = "input-required";
        public const string Completed = "completed";
        public const string Canceled = "canceled";
        public const string Failed = "failed";
        public const string Unknown = "unknown";
    }

    // --- TaskStatus ---
    public class TaskStatus
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("message")]
        public Message Message { get; set; }

        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }
    }

    // --- Task ---
    public class Task
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("status")]
        public TaskStatus Status { get; set; }

        [JsonProperty("artifacts")]
        public List<Artifact> Artifacts { get; set; }

        [JsonProperty("history")]
        public List<Message> History { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, object> Metadata { get; set; }
    }

    // --- JSON-RPC Base Types ---
    public class JSONRPCMessage
    {
        [JsonProperty("jsonrpc")]
        public string JsonRpc { get; set; } = "2.0";

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class JSONRPCRequest : JSONRPCMessage
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("params")]
        public Dictionary<string, object> Params { get; set; }
    }

    public class JSONRPCResponse : JSONRPCMessage
    {
        [JsonProperty("result")]
        public object Result { get; set; }

        [JsonProperty("error")]
        public JSONRPCError Error { get; set; }
    }

    // --- JSON-RPC Error ---
    public class JSONRPCError
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, object> Data { get; set; }
    }

    // --- Example Error Types ---
    public class InvalidRequestError : JSONRPCError
    {
        public InvalidRequestError()
        {
            Code = -32600;
            Message = "Request payload validation error";
        }
    }

    public class InvalidParamsError : JSONRPCError
    {
        public InvalidParamsError()
        {
            Code = -32602;
            Message = "Invalid parameters";
        }
    }

    public class MethodNotFoundError : JSONRPCError
    {
        public MethodNotFoundError()
        {
            Code = -32601;
            Message = "Method not found";
        }
    }

    public class InternalError : JSONRPCError
    {
        public InternalError()
        {
            Code = -32603;
            Message = "Internal error";
        }
    }

    public class JSONParseError : JSONRPCError
    {
        public JSONParseError()
        {
            Code = -32700;
            Message = "Invalid JSON payload";
        }
    }

    // --- AuthenticationInfo ---
    public class AuthenticationInfo
    {
        [JsonProperty("schemes")]
        public List<string> Schemes { get; set; }

        [JsonProperty("credentials")]
        public string Credentials { get; set; }
    }

    // --- PushNotificationConfig ---
    public class PushNotificationConfig
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("authentication")]
        public AuthenticationInfo Authentication { get; set; }
    }

    // --- TaskPushNotificationConfig ---
    public class TaskPushNotificationConfig
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("pushNotificationConfig")]
        public PushNotificationConfig PushNotificationConfig { get; set; }
    }

    // --- TaskIdParams ---
    public class TaskIdParams
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, object> Metadata { get; set; }
    }

    // --- TaskQueryParams ---
    public class TaskQueryParams
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("historyLength")]
        public int? HistoryLength { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, object> Metadata { get; set; }
    }

    public class MessageSendConfiguration
    {
        [JsonProperty("acceptedOutputModes")]
        public string[] AcceptedOutputModes { get; set; }

        [JsonProperty("historyLength")]
        public int? HistoryLength { get; set; }

        [JsonProperty("pushNotificationConfig")]
        public PushNotificationConfig PushNotificationConfig { get; set; }

        [JsonProperty("blocking")]
        public bool? Blocking { get; set; }
    }

    // --- TaskSendParams ---
    public class TaskSendParams
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("message")]
        public Message Message { get; set; }

        [JsonProperty("pushNotification")]
        public PushNotificationConfig PushNotification { get; set; }

        [JsonProperty("historyLength")]
        public int? HistoryLength { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, object> Metadata { get; set; }
    }

    // --- TaskStatusUpdateEvent ---
    public class TaskStatusUpdateEvent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public TaskStatus Status { get; set; }

        [JsonProperty("final")]
        public bool? Final { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, object> Metadata { get; set; }
    }

    // --- TaskArtifactUpdateEvent ---
    public class TaskArtifactUpdateEvent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("artifact")]
        public Artifact Artifact { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, object> Metadata { get; set; }
    }
}