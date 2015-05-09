﻿using System;

namespace WebVella.ERP.Api.Models
{
    public class HtmlField : Field
    {
        public static FieldType FieldType { get { return FieldType.HtmlField; } }

        public string DefaultValue { get; set; }
    }

    public class HtmlFieldMeta : HtmlField
    {
		public Guid EntityId { get; set; }

		public string EntityName { get; set; }

		public HtmlFieldMeta(Guid entityId, string entityName, HtmlField field)
		{
			EntityId = entityId;
			EntityName = entityName;
			DefaultValue = field.DefaultValue;
		}
	}
}