﻿using ScaffoldCode.Domain.Entidades;
using System.Collections.Generic;

namespace ScaffoldCode.Domain.Interfaces.Repositorios
{
    public interface IRepositorioColunas
    {
        List<columns> ObterColunas(int idObjeto, int? idPKey);
    }
}
