﻿using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Assignable {
	using ImsGlobal.Caliper.Util;

	[JsonConverter( typeof( JsonValueConverter<AssignableDigitalResourceType> ) )]
	public sealed class AssignableDigitalResourceType : IType, IJsonValue {

		public static readonly AssignableDigitalResourceType Assessment = new AssignableDigitalResourceType( "http://purl.imsglobal.org/caliper/v1/Assessment" );
		public static readonly AssignableDigitalResourceType AssessmentItem = new AssignableDigitalResourceType( "http://purl.imsglobal.org/caliper/v1/AssessmentItem" );

		public AssignableDigitalResourceType() {}

		public AssignableDigitalResourceType( string value ) {
			this.Value = value;
		}

		public string Value { get; set; }
	}
}