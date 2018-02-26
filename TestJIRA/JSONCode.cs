// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using TestJIRA;
//
//    var data = Welcome.FromJson(jsonString);

namespace TestJIRA
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    //public partial class Results
    //{
    //    [JsonProperty("result")]
    //    public Result[] Result { get; set; }
    //}

    public partial class Results
    {
        [JsonProperty("result")]
        public List<Result> Results1 { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("active")]
        public string Active { get; set; }

        [JsonProperty("activity_due")]
        public string ActivityDue { get; set; }

        [JsonProperty("additional_assignee_list")]
        public string AdditionalAssigneeList { get; set; }

        [JsonProperty("approval")]
        public string Approval { get; set; }

        [JsonProperty("approval_history")]
        public string ApprovalHistory { get; set; }

        [JsonProperty("approval_set")]
        public string ApprovalSet { get; set; }

        [JsonProperty("assigned_to")]
        public AssignedTo AssignedTo { get; set; }

        [JsonProperty("assignment_group")]
        public AssignedTo AssignmentGroup { get; set; }

        [JsonProperty("business_duration")]
        public string BusinessDuration { get; set; }

        [JsonProperty("business_service")]
        public BusinessService BusinessService { get; set; }

        [JsonProperty("business_stc")]
        public string BusinessStc { get; set; }

        [JsonProperty("calendar_duration")]
        public string CalendarDuration { get; set; }

        [JsonProperty("calendar_stc")]
        public string CalendarStc { get; set; }

        [JsonProperty("caller_id")]
        public AssignedTo CallerId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("caused_by")]
        public string CausedBy { get; set; }

        [JsonProperty("child_incidents")]
        public string ChildIncidents { get; set; }

        [JsonProperty("close_code")]
        public string CloseCode { get; set; }

        [JsonProperty("close_notes")]
        public string CloseNotes { get; set; }

        [JsonProperty("closed_at")]
        public string ClosedAt { get; set; }

        [JsonProperty("closed_by")]
        public EdBy ClosedBy { get; set; }

        [JsonProperty("cmdb_ci")]
        public AssignedTo CmdbCi { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("comments_and_work_notes")]
        public string CommentsAndWorkNotes { get; set; }

        [JsonProperty("company")]
        public Company Company { get; set; }

        [JsonProperty("contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("correlation_display")]
        public string CorrelationDisplay { get; set; }

        [JsonProperty("correlation_id")]
        public string CorrelationId { get; set; }

        [JsonProperty("delivery_plan")]
        public string DeliveryPlan { get; set; }

        [JsonProperty("delivery_task")]
        public string DeliveryTask { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("escalation")]
        public string Escalation { get; set; }

        [JsonProperty("expected_start")]
        public string ExpectedStart { get; set; }

        [JsonProperty("follow_up")]
        public string FollowUp { get; set; }

        [JsonProperty("group_list")]
        public string GroupList { get; set; }

        [JsonProperty("hold_reason")]
        public string HoldReason { get; set; }

        [JsonProperty("impact")]
        public string Impact { get; set; }

        [JsonProperty("incident_state")]
        public string IncidentState { get; set; }

        [JsonProperty("knowledge")]
        public string Knowledge { get; set; }

        [JsonProperty("location")]
        public AssignedTo Location { get; set; }

        [JsonProperty("made_sla")]
        public string MadeSla { get; set; }

        [JsonProperty("notify")]
        public string Notify { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("opened_at")]
        public System.DateTime OpenedAt { get; set; }

        [JsonProperty("opened_by")]
        public AssignedTo OpenedBy { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("parent_incident")]
        public string ParentIncident { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("problem_id")]
        public AssignedTo ProblemId { get; set; }

        [JsonProperty("reassignment_count")]
        public string ReassignmentCount { get; set; }

        [JsonProperty("reopen_count")]
        public string ReopenCount { get; set; }

        [JsonProperty("resolved_at")]
        public string ResolvedAt { get; set; }

        [JsonProperty("resolved_by")]
        public EdBy ResolvedBy { get; set; }

        [JsonProperty("rfc")]
        public string Rfc { get; set; }

        [JsonProperty("severity")]
        public string Severity { get; set; }

        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        [JsonProperty("sla_due")]
        public string SlaDue { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("sys_class_name")]
        public string SysClassName { get; set; }

        [JsonProperty("sys_created_by")]
        public string SysCreatedBy { get; set; }

        [JsonProperty("sys_created_on")]
        public System.DateTime SysCreatedOn { get; set; }

        [JsonProperty("sys_domain")]
        public AssignedTo SysDomain { get; set; }

        [JsonProperty("sys_domain_path")]
        public string SysDomainPath { get; set; }

        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("sys_mod_count")]
        public string SysModCount { get; set; }

        [JsonProperty("sys_tags")]
        public string SysTags { get; set; }

        [JsonProperty("sys_updated_by")]
        public string SysUpdatedBy { get; set; }

        [JsonProperty("sys_updated_on")]
        public System.DateTime SysUpdatedOn { get; set; }

        [JsonProperty("time_worked")]
        public string TimeWorked { get; set; }

        [JsonProperty("upon_approval")]
        public string UponApproval { get; set; }

        [JsonProperty("upon_reject")]
        public string UponReject { get; set; }

        [JsonProperty("urgency")]
        public string Urgency { get; set; }

        [JsonProperty("user_input")]
        public string UserInput { get; set; }

        [JsonProperty("watch_list")]
        public string WatchList { get; set; }

        [JsonProperty("work_end")]
        public string WorkEnd { get; set; }

        [JsonProperty("work_notes")]
        public string WorkNotes { get; set; }

        [JsonProperty("work_notes_list")]
        public string WorkNotesList { get; set; }

        [JsonProperty("work_start")]
        public string WorkStart { get; set; }
    }

    public partial class AssignedTo
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }


    public partial class Company
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class BusinessService
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class EdBy
    {
        public AssignedTo AssignedTo;
        public string String;
    }

    public partial class Welcome
    {
        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, Converter.Settings);
    }

    public partial class EdBy
    {
        public EdBy(JsonReader reader, JsonSerializer serializer)
        {
            AssignedTo = null;
            String = null;

            if(reader == null)
            {
                return;
            }

            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    AssignedTo = serializer.Deserialize<AssignedTo>(reader);
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    String = serializer.Deserialize<string>(reader);
                    return;
            }
            throw new Exception("Cannot convert EdBy");
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (AssignedTo != null)
            {
                serializer.Serialize(writer, AssignedTo);
                return;
            }
            if (String != null)
            {
                serializer.Serialize(writer, String);
                return;
            }
            throw new Exception("Union must not be null");
        }
    }

    public static class Serialize
    {
        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EdBy);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (t == typeof(EdBy))
                return new EdBy(reader, serializer);
            throw new Exception("Unknown type");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var t = value.GetType();
            if (t == typeof(EdBy))
            {
                ((EdBy)value).WriteJson(writer, serializer);
                return;
            }
            throw new Exception("Unknown type");
        }

        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = { new Converter() },
        };
    }
}