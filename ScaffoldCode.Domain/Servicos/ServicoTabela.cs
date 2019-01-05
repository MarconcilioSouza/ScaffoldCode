using ScaffoldCode.Domain.Entidades;
using ScaffoldCode.Infra.Helpers.HelperExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScaffoldCode.Domain.Servicos
{
    public class ServicoTabela
    {
        public Int32 IdObjeto;
        public String Name;
        public String Type;
        public Int32? IdPKey;

        //public Colunas ColPKey = null;
        //public Int32 PKCols = 0;

        //public List<Colunas> Cols { get; private set; }
        //public List<Colunas> ColsSemTS
        //{
        //    get { return Cols.FindAll(N => N.TipoCampo != "timestamp"); }
        //}
        //public List<Colunas> ColsSemTSSemDtInclusao
        //{
        //    get
        //    {
        //        return ColsSemTS.FindAll(N =>
        //      !N.NomeCampo.Contains("DtInclusao") || N.TipoCampo != "datetime");
        //    }
        //}

        //private String m_ViewText = String.Empty;
        //public String ViewText
        //{
        //    get { return m_ViewText; }
        //}

        //public void CarregaViewText()
        //{
        //    //    SqlCommand cmdObj = dbConn.CreateCommand();
        //    //    SqlDataReader rdObj = null;

        //    //    try
        //    //    {
        //    //        // 1o le o Texto de todos os Views
        //    //        StringBuilder Result = new StringBuilder();

        //    //        cmdObj.CommandText =
        //    //            "select text from syscomments " + Environment.NewLine +
        //    //            " where id = " + IdObjeto.ToString() + Environment.NewLine +
        //    //            " order by colid ";

        //    //        rdObj = cmdObj.ExecuteReader();
        //    //        while (rdObj.Read())
        //    //            Result.Append(rdObj["text"].ToString());

        //    //        m_ViewText = Result.ToString();
        //    //    }
        //    //    finally
        //    //    {
        //    //        rdObj.Close();
        //    //    }
        //}

        //// Herdado ?
        //private ServicoTabela m_TabHerd = null;
        //public ServicoTabela TabHerd
        //{
        //    get { return m_TabHerd; }
        //}
        //private int m_CamposHerd = 0;
        //public Int32 CamposHerd
        //{
        //    get { return m_CamposHerd; }
        //}

        ///// <summary>
        ///// Conta o número de campos iguais na mesma posição
        ///// </summary>
        //private Int32 CamposIguais(List<Colunas> colsHerd)
        //{
        //    // Se no herdado tiver mais colunas que neste não pode ser herdado
        //    if (colsHerd.Count > Cols.Count)
        //        return 0;

        //    foreach (var CDef in colsHerd)
        //    {
        //        if (!CDef.EIgual(Cols[CDef.Index]))
        //            return 0;
        //    }
        //    return colsHerd.Count;
        //}

        //public void VerifTabHerd(List<ServicoTabela> tabelas)
        //{
        //    foreach (ServicoTabela tabela in tabelas)
        //    {
        //        if (tabela != this && tabela.Type == "U")
        //        {
        //            // Views só podem ser herdados se todos os campos estã no view 
        //            // e na mesma posição !
        //            Int32 CH = CamposIguais(tabela.Cols);
        //            if (CH == tabela.Cols.Count && CH > m_CamposHerd)
        //            {
        //                m_TabHerd = tabela;
        //                m_CamposHerd = CH;
        //            }
        //        }
        //    }
        //}


        //public ServicoTabela(String name)
        //{
        //    //SqlCommand cmdObj = dbConn.CreateCommand();
        //    //SqlDataReader rdObj = null;

        //    //try
        //    //{
        //    //    cmdObj.CommandText =
        //    //        "SELECT SO.name, SO.type, SO.object_id, " + Environment.NewLine +
        //    //        "   PK.unique_index_id AS PKID " + Environment.NewLine +
        //    //        " FROM sys.objects SO " + Environment.NewLine +
        //    //        " LEFT JOIN sys.key_constraints PK " + Environment.NewLine +
        //    //        "  ON  PK.parent_object_id = SO.object_id " + Environment.NewLine +
        //    //        "  AND PK.type = 'PK' " + Environment.NewLine +
        //    //        " where SO.name='" + name + "'";

        //    //    rdObj = cmdObj.ExecuteReader();
        //    //    if (!rdObj.Read())
        //    //        throw new Exception("Objeto nao encontrado");

        //    //    Name = rdObj.GetString(0);
        //    //    Type = rdObj.GetString(1).Trim();
        //    //    IdObjeto = rdObj.GetInt32(2);
        //    //    IdPKey = null;
        //    //    if (!rdObj.IsDBNull(3))
        //    //        IdPKey = rdObj.GetInt32(3);
        //    //}
        //    //finally
        //    //{
        //    //    rdObj.Close();
        //    //}

        //    //Cols = new List<Colunas>();

        //    //if (Type == "P")
        //    //    LerParametros(cmdObj);
        //    //else
        //    //    LerColunas(cmdObj);
        //}

        //private void ObterColunas()
        //{
        //    //SqlDataReader rdObj = null;
        //    //try
        //    //{
        //    ////    cmdObj.CommandText =
        //    //        "SELECT SC.column_id, SC.name, SC.max_length, SC.precision, " + Environment.NewLine +
        //    //        "   CAST(SC.scale as smallint) as scale, " + Environment.NewLine +
        //    //        "   RTRIM(TP.name) AS Tipo, SC.is_nullable, " + Environment.NewLine +
        //    //        "   CAST(IC.key_ordinal as smallint) as key_ordinal " + Environment.NewLine +
        //    //        " FROM sys.columns SC " + Environment.NewLine +
        //    //        " JOIN sys.types TP " + Environment.NewLine +
        //    //        "  ON  TP.system_type_id = SC.system_type_id " + Environment.NewLine +
        //    //        "  AND TP.user_type_id = SC.user_type_id " + Environment.NewLine +
        //    //        " LEFT JOIN sys.index_columns IC " + Environment.NewLine +
        //    //        "  on  IC.object_id = SC.object_id " + Environment.NewLine +
        //    //        "  and IC.index_id = " + IdPKey.GetValueOrDefault().ToString() + Environment.NewLine +
        //    //        "  and IC.column_id = SC.column_id " + Environment.NewLine +
        //    //        " where SC.object_id =" + IdObjeto.ToString() + Environment.NewLine +
        //    //        " order by SC.column_id ";

        //    //    rdObj = cmdObj.ExecuteReader();
        //    //    while (rdObj.Read())
        //    //    {
        //    //        Colunas Col = new Colunas();

        //    //        Col.IdColuna = rdObj.GetInt32(0);
        //    //        Col.NomeCampo = rdObj.GetString(1);
        //    //        Col.Tamanho = rdObj.GetInt16(2);
        //    //        Col.Digitos = rdObj.GetInt16(4);
        //    //        Col.TipoCampo = rdObj.GetString(5);
        //    //        Col.PermNull = rdObj.GetBoolean(6);
        //    //        Col.IsOutParam = false;
        //    //        Col.PKey = null;
        //    //        if (!rdObj.IsDBNull(7))
        //    //            Col.PKey = rdObj.GetInt16(7);      // key_ordinal começa em 1
        //    //        Col.Index = Cols.Count;

        //    //        Cols.Add(Col);

        //    //        // Guarda a coluna do PK
        //    //        if (Col.PKey.HasValue)
        //    //        {
        //    //            if (ColPKey == null)
        //    //                ColPKey = Col;
        //    //            PKCols++;
        //    //        }
        //    //    }
        //    //}
        //    //finally
        //    //{
        //    //    rdObj.Close();
        //    //}
        //    //return rdObj;
        //}

        //private void LerParametros()
        //{
        //    //SqlDataReader rdObj = null;
        //    //try
        //    //{
        //    //    cmdObj.CommandText =
        //    //        "SELECT P.parameter_id, P.name, P.max_length, P.precision, " + Environment.NewLine +
        //    //        "   CAST(P.scale as smallint) as scale, " + Environment.NewLine +
        //    //        "   RTRIM(TP.name) AS Tipo, P.is_output " + Environment.NewLine +
        //    //        " FROM sys.parameters P " + Environment.NewLine +
        //    //        " JOIN sys.types TP " + Environment.NewLine +
        //    //        "  ON  TP.system_type_id = P.system_type_id " + Environment.NewLine +
        //    //        "  AND TP.user_type_id = P.user_type_id " + Environment.NewLine +
        //    //        " where P.object_id =" + IdObjeto.ToString() + Environment.NewLine +
        //    //        " order by P.parameter_id ";

        //    //    rdObj = cmdObj.ExecuteReader();
        //    //    while (rdObj.Read())
        //    //    {
        //    //        Colunas Col = new Colunas();

        //    //        Col.IdColuna = rdObj.GetInt32(0);
        //    //        String NomeCampo = rdObj.GetString(1);
        //    //        Col.NomeCampo = NomeCampo.Replace("@", String.Empty);
        //    //        Col.Tamanho = rdObj.GetInt16(2);
        //    //        Col.Digitos = rdObj.GetInt16(4);
        //    //        Col.TipoCampo = rdObj.GetString(5);
        //    //        Col.PermNull = true;
        //    //        Col.IsOutParam = rdObj.GetBoolean(6);
        //    //        Col.PKey = null;
        //    //        Col.Index = Cols.Count;

        //    //        Cols.Add(Col);
        //    //    }
        //    //}
        //    //finally
        //    //{
        //    //    rdObj.Close();
        //    //}
        //    //return rdObj;
        //}

        //// Retorna a Qtde de Chaves
        //public Int32 Keys
        //{
        //    get
        //    {
        //        return PKCols;
        //    }
        //}

        //// Standard Pkey é um unico 1o campo na PK.
        //public bool TemIStdPKey
        //{
        //    get
        //    {
        //        return PKCols == 1 && Cols[0] == ColPKey
        //            && ColPKey.TipoCampo == "int";
        //    }
        //}

        //// Retorna o Nome do Class a partir do Tipo
        //public String NomeClass
        //{
        //    get
        //    {
        //        /*
        //        if (Type == "U")
        //            return "tb" + Name;
        //        if (Type == "V")
        //            return "vw" + Name;
        //        if (Type == "P")
        //            return "sp" + Name;
        //         */

        //        return Name;
        //    }
        //}

        //public void GeraPKeyInterface(StringBuilder Out, Colunas PKFld)
        //{
        //    Out.ApLine();
        //    Out.ApLine("        // Open by PK");
        //    Out.ApLine("        public void OpenPK(Int32 pkVal)");
        //    Out.ApLine("        {");
        //    Out.ApLine("            Close();");
        //    Out.ApLine();
        //    Out.ApLine("            Open(");
        //    Out.Append("                \"select * from ")
        //        .Append(Name)
        //        .ApLine(" \" + Environment.NewLine +");
        //    Out.Append("                \" where ")
        //        .Append(PKFld.NomeCampo)
        //        .ApLine(" = \" + pkVal.ToString());");
        //    Out.ApLine("        }");
        //    Out.ApLine();

        //    Out.ApLine("        public DBInt32Field PKField()");
        //    Out.ApLine("        {");
        //    Out.Append("            return ")
        //        .Append(PKFld.NomeCampo)
        //        .ApLine(";");
        //    Out.ApLine("        }");
        //}

        //public void GeraRecFuncs(StringBuilder Out, String New)
        //{
        //    String T = "r" + NomeClass;

        //    Out.ApLine();
        //    Out.ApLine("        // Copia os Campos do Cursor para o registro");
        //    Out.Append("        public void CursorToRec(")
        //        .Append(T)
        //        .ApLine(" reg)");
        //    Out.ApLine("        {");
        //    foreach (Colunas Coluna in Cols)
        //    {
        //        Coluna.GravaAtribVar(Out);
        //    }

        //    Out.ApLine("        }");

        //    List<Colunas> ColsSemTS = Cols.FindAll(N => N.TipoCampo != "timestamp");

        //    Out.ApLine();
        //    Out.ApLine("        // Copia os Campos do registro para o Cursor");
        //    Out.Append("        public void RecToCursor(")
        //        .Append(T)
        //        .ApLine(" reg)");
        //    Out.ApLine("        {");
        //    foreach (Colunas Coluna in ColsSemTS)     // Sem Timestamp !!
        //    {
        //        Coluna.GravaAtribFld(Out);
        //    }
        //    Out.ApLine("        }");
        //}

        //public void GravaCursor(StringBuilder Out)
        //{
        //    Out.Append("    // Tabela ")
        //        .ApLine(Name);
        //    Out.Append("    public partial class ")
        //        .Append(NomeClass)
        //        .Append(" : DBCursor, IRecFuncs&lt;r")
        //        .Append(NomeClass)
        //        .Append("&gt;");
        //    if (TemIStdPKey)
        //        Out.ApLine(", IStdPKey");
        //    Out.ApLine("    {");

        //    foreach (Colunas Coluna in Cols)
        //    {
        //        Coluna.GravaDeclField(Out);
        //    }

        //    Out.ApLine();
        //    Out.ApLine("        // Constructor");
        //    Out.Append("        public ")
        //        .Append(NomeClass);
        //    Out.ApLine("(DBConnection Conn)");
        //    Out.ApLine("            : base(Conn)");
        //    Out.ApLine("        {");

        //    Out.Append("            Name = \"")
        //        .Append(NomeClass)
        //        .ApLine("\";");
        //    Out.ApLine();

        //    foreach (Colunas Coluna in Cols)
        //    {
        //        Coluna.GravaInicField(Out);
        //    }

        //    Out.ApLine("        }");

        //    if (TemIStdPKey)
        //        GeraPKeyInterface(Out, ColPKey);

        //    GeraRecFuncs(Out, String.Empty);

        //    Out.ApLine("    }");
        //    Out.ApLine();
        //}

        //private void GravaPoco(StringBuilder Out, ServicoTabela tabHerd, Int32 camposHerd)
        //{
        //    Out.Append("    public partial class ")
        //        .Append(Name);

        //    if (tabHerd != null)
        //    {
        //        Out.Append(" : ")
        //            .Append(tabHerd.Name);
        //    }
        //    //else if (TemIStdPKey)
        //    //{
        //    //    Out.Append(" : IRecPKey");
        //    //}

        //    Out.ApLine();
        //    Out.ApLine("    {");

        //    foreach (Colunas Coluna in Cols)
        //    {
        //        if (Coluna.Index >= camposHerd)
        //            Coluna.GravaDeclVar(Out, PKCols);
        //    }

        //    //if (tabHerd == null && TemIStdPKey)
        //    //{
        //    //    Out.ApLine();
        //    //    Out.ApLine("        [NotMapped]");
        //    //    Out.ApLine("        public Int32 PKValue");
        //    //    Out.ApLine("        {");
        //    //    Out.Append("            get { return ")
        //    //        .Append(ColPKey.NomeCampo)
        //    //        .ApLine("; }");
        //    //    Out.ApLine("        }");
        //    //}

        //    Out.ApLine("    }");
        //    Out.ApLine();
        //}

        //public void GravaPocoTab(StringBuilder Out)
        //{
        //    Out.Append("    // Poco ")
        //        .ApLine(Name);

        //    Out.Append("    [Serializable, Table(\"")
        //        .Append(Name)
        //        .ApLine("\")]");

        //    GravaPoco(Out, null, 0);
        //}

        //public void GravaPocoView(StringBuilder Out)
        //{
        //    Out.Append("    // Poco ")
        //        .ApLine(Name);

        //    Out.ApLine("    [Serializable, NotMapped]");

        //    GravaPoco(Out, TabHerd, CamposHerd);
        //}

        //public void GravaView(StringBuilder Out)
        //{
        //    Out.Append("    /* View ")
        //        .ApLine(Name);
        //    Out.ApLine(ViewText);
        //    Out.ApLine("    */");
        //    Out.Append("    public partial class ")
        //        .Append(NomeClass)
        //        .Append(" : ");
        //    Out.Append("DBCursor, IRecFuncs&lt;r")
        //        .Append(NomeClass)
        //        .Append("&gt;");

        //    if (TabHerd != null)
        //        if (TabHerd.TemIStdPKey)
        //            Out.Append(", IStdPKey");

        //    Out.ApLine();
        //    Out.ApLine("    {");

        //    foreach (Colunas Coluna in Cols)
        //    {
        //        //if (Coluna.Index >= CamposHerd)
        //        Coluna.GravaDeclField(Out);
        //    }

        //    Out.ApLine();
        //    Out.ApLine("        // Constructor");
        //    Out.Append("        public ")
        //        .Append(NomeClass)
        //        .ApLine("(DBConnection Conn)");
        //    Out.ApLine("            : base(Conn)");
        //    Out.ApLine("        {");

        //    Out.Append("            Name = \"")
        //        .Append(NomeClass)
        //        .ApLine("\";");
        //    Out.ApLine();

        //    foreach (Colunas Coluna in Cols)
        //    {
        //        // if (Coluna.Index >= CamposHerd)
        //        Coluna.GravaInicField(Out);
        //    }
        //    Out.ApLine("        }");

        //    if (TabHerd != null)
        //        if (TabHerd.TemIStdPKey)
        //            GeraPKeyInterface(Out, TabHerd.ColPKey);

        //    GeraRecFuncs(Out, "new");

        //    Out.ApLine("    }");
        //    Out.ApLine();
        //}

        //// Grava construtores a partir do cursor e do registro
        //public void GravaConstructorHerdProc(StringBuilder Out, ServicoTabela tabHerd,
        //    Int32 camposHerd, Boolean soPoco)
        //{
        //    if (!soPoco)
        //    {
        //        Out.ApLine();
        //        Out.ApLine("        // Constructor Cursor");
        //        Out.Append("        public ")
        //            .Append(NomeClass)
        //            .Append("(")
        //            .Append(tabHerd.NomeClass)
        //            .ApLine(" crsr)");
        //        Out.ApLine("            : this(crsr.Connection)");
        //        Out.ApLine("        {");

        //        foreach (Colunas Coluna in Cols)
        //        {
        //            // Copiar campo herdado do Cursor ??
        //            if (Coluna.Index < camposHerd)
        //            {
        //                Out.Append("            ");
        //                Out.Append(Coluna.NomeCampo);
        //                Out.Append(".NValue = crsr.");
        //                Out.Append(Coluna.NomeCampo);
        //                Out.ApLine(".NValue;");
        //            }
        //        }
        //        Out.ApLine("        }");
        //    }
        //    Out.ApLine();
        //    Out.ApLine("        // Constructor Poco");
        //    Out.Append("        public ")
        //        .Append(NomeClass)
        //        .Append("(DBConnection dbConn, r")
        //        .Append(tabHerd.NomeClass)
        //        .ApLine(" rec)");
        //    Out.ApLine("            : this(dbConn)");
        //    Out.ApLine("        {");

        //    foreach (Colunas Coluna in Cols)
        //    {
        //        // Copiar campo herdado do Cursor ??
        //        if (Coluna.Index < camposHerd)
        //        {
        //            Out.Append("            ");
        //            Out.Append(Coluna.NomeCampo);
        //            Out.Append(".NValue = rec.");
        //            Out.Append(Coluna.NomeCampo);
        //            Out.ApLine(";");
        //        }
        //    }
        //    Out.ApLine("        }");
        //}

        //public void GravaProc(List<ServicoTabela> tabelas, StringBuilder Out, Boolean soPoco)
        //{
        //    Out.ApLine();
        //    Out.Append("    // Proc ")
        //        .ApLine(Name);
        //    Out.Append("    public class ")
        //        .Append(NomeClass)
        //        .ApLine(" : DBProc");
        //    Out.ApLine("    {");
        //    foreach (Colunas Coluna in Cols)
        //    {
        //        Coluna.GravaDeclField(Out);
        //    }

        //    // Grava um constructor default com que constroi todas as colunas
        //    Out.ApLine();
        //    Out.ApLine("        // Constructor");
        //    Out.Append("        public ")
        //        .Append(NomeClass)
        //        .ApLine("(DBConnection Conn)");
        //    Out.ApLine("            : base(Conn)");
        //    Out.ApLine("        {");

        //    foreach (Colunas Coluna in Cols)
        //    {
        //        Coluna.GravaInicField(Out);
        //    }
        //    Out.ApLine();
        //    Out.ApLine("            Command.CommandType = CommandType.StoredProcedure;");
        //    Out.Append("            Command.CommandText = \"")
        //        .Append(Name)
        //        .ApLine("\";");
        //    Out.ApLine("        }");

        //    /* Constructors a partir de tabelas ?
        //     * Só se tiver na mesma posição para evitar confusão....
        //     * Disconsidera o DtInclusao DateTime e campos tipo TimeStamp
        //     */
        //    foreach (ServicoTabela tabela in tabelas)
        //    {
        //        if (tabela != this && tabela.Type == "U")    // Somente Tabelas
        //        {
        //            Int32 CH = CamposIguais(tabela.ColsSemTSSemDtInclusao);
        //            if (CH > 0)
        //                GravaConstructorHerdProc(Out, tabela, CH, soPoco);
        //        }
        //    }

        //    Out.ApLine("    }");
        //}

        //public void GeraProcSql(StringBuilder SB)
        //{
        //    const Int32 MaxInsL = 40;

        //    // Os campos sem o Timestamp
        //    // Será o 1o lambda da historia ??
        //    Colunas LastCol = ColsSemTS.FindLast(N => true);

        //    // Troca o tb_ pelo sp_ !!
        //    String NomeSp = Name;
        //    Int32 NameL = Name.Length - 3;
        //    if (NameL > 0)
        //        if (Name.Substring(0, 3).ToLower() == "tb_")
        //            NomeSp = "sp_" + Name.Substring(3, NameL);

        //    SB.ApLine("Create Proc " + NomeSp + "_Update");
        //    foreach (Colunas Col in ColsSemTS)
        //    {
        //        SB.Append("  @");
        //        SB.Append(Col.NomeCampo);
        //        SB.Append(" ");
        //        SB.Append(Col.SqlVar);
        //        SB.ApLine(",");
        //    }
        //    SB.ApLine("  @SqlType nvarchar(20),");
        //    SB.ApLine("  @IdUsuarioAlt int,");
        //    SB.Append("  @")
        //        .Append(ColPKey.NomeCampo)
        //        .ApLine("_Out int output");
        //    SB.ApLine("as");
        //    SB.ApLine("begin");
        //    SB.ApLine("  Set Xact_Abort on");
        //    SB.ApLine("  Set Nocount on");
        //    SB.ApLine("  Begin Tran");
        //    SB.ApLine();

        //    SB.ApLine("  If @SqlType = 'Insert'");
        //    SB.ApLine("  begin");
        //    SB.Append("    Insert into " + Name + " (");

        //    Int32 InsL = MaxInsL;               // Força Quebra
        //    foreach (Colunas Col in ColsSemTS)
        //    {
        //        if (InsL >= MaxInsL)
        //        {
        //            SB.ApLine();
        //            SB.Append("     ");
        //            InsL = 0;
        //        }
        //        if (Col != ColPKey)
        //        {
        //            SB.Append(" ");
        //            SB.Append(Col.NomeCampo);
        //            if (Col != LastCol)
        //                SB.Append(",");
        //            InsL += Col.NomeCampo.Length;
        //        }
        //    }
        //    SB.ApLine();
        //    SB.Append("     ) values (");

        //    InsL = MaxInsL;
        //    foreach (Colunas Col in ColsSemTS)
        //    {
        //        if (InsL >= MaxInsL)
        //        {
        //            SB.ApLine();
        //            SB.Append("     ");
        //            InsL = 0;
        //        }
        //        if (Col != ColPKey)
        //        {
        //            SB.Append(" @");
        //            SB.Append(Col.NomeCampo);
        //            if (Col != LastCol)
        //                SB.Append(",");
        //            InsL += Col.NomeCampo.Length;
        //        }
        //    }
        //    SB.ApLine();
        //    SB.ApLine("     )");
        //    SB.ApLine("    Set @" + ColPKey.NomeCampo + "_Out = @@IDENTITY");
        //    SB.ApLine("  end");

        //    SB.ApLine();
        //    SB.ApLine("  If @SqlType = 'Update'");
        //    SB.ApLine("  begin");
        //    SB.ApLine("    Update " + Name + " set");

        //    foreach (Colunas Col in ColsSemTS)
        //    {
        //        if (Col != ColPKey)
        //        {
        //            SB.Append("      ");
        //            SB.Append(Col.NomeCampo);
        //            SB.Append(" = @");
        //            SB.Append(Col.NomeCampo);
        //            if (Col != LastCol)
        //                SB.Append(",");
        //            SB.ApLine();
        //        }
        //    }
        //    SB.ApLine("     where " + ColPKey.NomeCampo + " = @" + ColPKey.NomeCampo);
        //    SB.ApLine("  end");
        //    SB.ApLine();

        //    SB.ApLine("  If @SqlType = 'Delete'");
        //    SB.ApLine("  begin");
        //    SB.ApLine("    Delete from " + Name);
        //    SB.ApLine("     where " + ColPKey.NomeCampo + " = @" + ColPKey.NomeCampo);
        //    SB.ApLine("  end");

        //    SB.ApLine();
        //    SB.ApLine("  Commit");
        //    SB.ApLine("end");
        //    SB.ApLine();
        //}
    }
}
