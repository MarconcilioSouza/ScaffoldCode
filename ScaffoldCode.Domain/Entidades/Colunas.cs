using ScaffoldCode.Infra.Helpers.HelperExtensions;
using System;
using System.Text;

namespace ScaffoldCode.Domain.Entidades
{
    public class Colunas
    {
        public Int32 IdColuna;
        public String NomeCampo;
        public String TipoCampo;
        public Int16 Tamanho;
        public Int16 Digitos;
        public Int16? PKey;
        public Boolean PermNull;
        public Boolean IsOutParam;
        public Int32 Index;

        public Boolean IsString
        {
            get
            {
                return TipoCampo == "char" || TipoCampo == "varchar" || TipoCampo == "text" ||
                        TipoCampo == "nchar" || TipoCampo == "nvarchar" || TipoCampo == "ntext";
            }
        }

        public Int32 TamString
        {
            get
            {
                return TipoCampo == "char" || TipoCampo == "varchar"
                    || TipoCampo == "text" || Tamanho < 0 ?
                    Tamanho : Tamanho / 2;
            }
        }

        public Boolean IsTimeStamp
        {
            get { return TipoCampo == "timestamp"; }
        }

        // Retorna o tipo de classe de acordo com o tipo do campo
        public String TipoField
        {
            get
            {
                if (TipoCampo == "int" || TipoCampo == "smallint")
                    return "DBInt32Field";

                if (TipoCampo == "bigint")
                    return "DBInt64Field";

                if (TipoCampo == "datetime")
                    return "DBDateTimeField";

                if (TipoCampo == "numeric")
                    return "DBDecimalField";

                if (IsString)
                    return "DBStringField";

                if (TipoCampo == "timestamp")
                    return "DBBinaryField";

                if (TipoCampo == "bit")
                    return "DBBooleanField";

                if (TipoCampo == "uniqueidentifier")
                    return "DBGuidField";

                return "?? " + TipoCampo + " ??";
            }
        }

        public string IsNullable
        {
            get { return PermNull ? "?" : String.Empty; }
        }

        // Retorna um variavel do tipo do campo
        public String TipoVar
        {
            get
            {
                if (TipoCampo == "smallint")
                    return "Int16" + IsNullable;

                if (TipoCampo == "int")
                    return "Int32" + IsNullable;

                if (TipoCampo == "bigint")
                    return "Int64" + IsNullable;

                if (TipoCampo == "date" || TipoCampo == "datetime" || TipoCampo == "smalldatetime")
                    return "DateTime" + IsNullable;

                if (TipoCampo == "numeric" || TipoCampo == "decimal")
                    return "Decimal" + IsNullable;

                if (IsString)
                    return "String";

                if (TipoCampo == "timestamp")
                    return "Byte[]";

                if (TipoCampo == "bit")
                    return "Boolean" + IsNullable;

                if (TipoCampo == "uniqueidentifier")
                    return "Guid" + IsNullable;

                return "?? " + TipoCampo + " ??";
            }
        }

        public String SqlVar
        {
            get
            {
                StringBuilder S = new StringBuilder(TipoCampo);

                // ToDo: E o numeric ??
                if (IsString)
                {
                    S.Append("(")
                        .Append(TamString > 0 ? TamString.ToString() : "MAX")
                        .Append(")");
                }
                if (TipoCampo == "numeric")
                {
                    S.Append("(")
                        .Append(Tamanho)
                        .Append(", ")
                        .Append(Digitos)
                        .Append(")");

                }
                return S.ToString();
            }
        }

        public Boolean EIgual(Colunas target)
        {
            // PKey não pode comparar pq nao tem no view/proc....
            // Idem null..
            return NomeCampo == target.NomeCampo &&
                TipoCampo == target.TipoCampo &&
                Tamanho == target.Tamanho &&
                Digitos == target.Digitos &&
                IsOutParam == target.IsOutParam;
        }

        public void GravaDeclField(StringBuilder Out)
        {
            Out.Append("        public ")
                .Append(TipoField)
                .Append(" ")
                .Append(NomeCampo)
                .ApLine(" { get; private set; }");
        }

        public void GravaDeclVar(StringBuilder Out, Int32 KeyCount)
        {
            if (PKey.HasValue)
            {
                Out.Append("        [Key");

                if (KeyCount > 1)
                {
                    Out.Append(", Column(Order=");
                    Out.Append(PKey.Value - 1);
                    Out.Append(")");
                }
                Out.ApLine("]");
            }

            else if (IsTimeStamp)
                Out.ApLine("        [Timestamp]");

            else if (IsString && TamString > 1)
            {
                Out.Append("        [MaxLength(");
                Out.Append(TamString);
                Out.ApLine(")]");
            }

            Out.Append("        public ")
                .Append(TipoVar)
                .Append(" ")
                .Append(NomeCampo)
                .ApLine(" { get; set; }");
        }

        public void GravaGetBase(StringBuilder Out)
        {
            Out.Append("        public ")
                .Append(TipoVar)
                .Append(" ")
                .Append(NomeCampo)
                .Append(" { get { return Base.")
                .Append(NomeCampo)
                .ApLine("; } }");
        }

        // Retorna um Create Coluna !
        private String CreateColuna
        {
            get
            {
                String PKey_Null_Output = PKey.HasValue + ", " + PermNull + ", " + IsOutParam;
                PKey_Null_Output = PKey_Null_Output.ToLower();

                if (TipoCampo == "int" || TipoCampo == "smallint")
                    return "DBInt32Field(this, \"" + NomeCampo + "\", " + PKey_Null_Output + ")";

                if (TipoCampo == "bigint")
                    return "DBInt64Field(this, \"" + NomeCampo + "\", " + PKey_Null_Output + ")";

                if (TipoCampo == "datetime")
                    return "DBDateTimeField(this, \"" + NomeCampo + "\", " + PKey_Null_Output + ")";

                if (TipoCampo == "numeric")
                    return "DBDecimalField(this, \"" + NomeCampo + "\", " + Digitos + ", " + PKey_Null_Output + ")";

                if (IsString)
                    return "DBStringField(this, \"" + NomeCampo + "\", " + TamString + ", " + PKey_Null_Output + ")";

                if (TipoCampo == "timestamp")
                    return "DBBinaryField(this, \"" + NomeCampo + "\", " + PKey_Null_Output + ")";

                if (TipoCampo == "bit")
                    return "DBBooleanField(this, \"" + NomeCampo + "\", " + PKey_Null_Output + ")";

                if (TipoCampo == "uniqueidentifier")
                    return "DBGuidField(this, \"" + NomeCampo + "\", " + PKey_Null_Output + ")";

                return "?? " + TipoCampo + " ??";
            }
        }

        public void GravaInicField(StringBuilder Out)
        {
            Out.Append("            ")
                .Append(NomeCampo)
                .Append(" = new ")
                .Append(CreateColuna)
                .ApLine(";");
        }

        public void GravaAtribVar(StringBuilder Out)
        {
            Out.Append("            reg.")
                .Append(NomeCampo)
                .Append(" = ")
                .Append(NomeCampo)
                .ApLine(PermNull ? ".NValue;" : ".Value;");
        }

        public void GravaAtribFld(StringBuilder Out)
        {
            Out.Append("            ")
                .Append(NomeCampo)
                .Append(".NValue = reg.")
                .Append(NomeCampo)
                .ApLine(";");
        }
    }
}
