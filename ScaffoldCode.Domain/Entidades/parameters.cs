namespace ScaffoldCode.Domain.Entidades
{
    public class parameters
    {
        public int object_id { get; set; }
        public string name { get; set; }
        public int parameter_id { get; set; }
        public int system_type_id { get; set; }
        public int user_type_id { get; set; }
        public int max_length { get; set; }
        public int precision { get; set; }
        public int scale { get; set; }
        public bool is_output { get; set; }
        public bool is_cursor_ref { get; set; }
        public bool has_default_value { get; set; }
        public bool is_xml_document { get; set; }
        public string default_value { get; set; }
        public int xml_collection_id { get; set; }
        public bool is_readonly { get; set; }
        public bool is_nullable { get; set; }
        public types type { get; set; }
    }
}
