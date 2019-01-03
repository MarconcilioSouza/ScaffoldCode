using Dapper;
using ScaffoldCode.Domain.Entidades;
using ScaffoldCode.Domain.Interfaces.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace ScaffoldCode.Infra.Data.Dapper
{
    public class RepositorioColunas : RepositorioBase, IRepositorioColunas
    {
        public List<Colunas> ObterColunas(int idObjeto, int? idPKey)
        {
            using (var cnn = GetConnection())
            {
                cnn.Open();
                var result = cnn.Query<Colunas>(
                    @"SELECT	SC.column_id as IdColuna, 
                                SC.name as NomeCampo, 
                                SC.max_length as Tamanho, 
                                -- SC.precision , 
                                CAST(SC.scale as smallint) as Digitos, 
                                RTRIM(TP.name) as TipoCampo, 
                                SC.is_nullable as PermNull, 
                                --0 as IsOutParam
                                CAST(IC.key_ordinal as smallint) as PKey 
                        FROM sys.columns SC 
                        JOIN sys.types TP 
                        ON  TP.system_type_id = SC.system_type_id 
                        AND TP.user_type_id = SC.user_type_id 
                        LEFT JOIN sys.index_columns IC 
                        on  IC.object_id = SC.object_id 
                        and IC.index_id =  + @IdPKey
                        and IC.column_id = SC.column_id 
                        where SC.object_id = + @IdObjeto
                        order by SC.column_id;", new { IdPKey = idPKey, IdObjeto = idObjeto })
                        .ToList();

                return result;
            }
        }
    }
}