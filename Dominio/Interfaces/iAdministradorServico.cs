using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using minimal_api.Dominio.Entidades;
using minimal_api.Dominio.DTOs;


namespace minimal_api.Dominio.Interfaces;

    public interface iAdministradorServico
    {
        Administrador? Login(LoginDTO loginDTO);
    }
