﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IMedico
    {
        #region Metodos
        void IniciarAtencion(Paciente p);
        #endregion
    }
}
