using System.Text;

namespace ScaffoldCode.Infra.Helpers.HelperExtensions
{
    public static class StringBuilderExtensions
    {
        // So para Append ficar alinhado com AppendLine !!
        public static StringBuilder ApLine(this StringBuilder sb)
        {
            return sb.AppendLine();
        }

        public static StringBuilder ApLine(this StringBuilder sb, string value)
        {
            return sb.AppendLine(value);
        }
    }
}
