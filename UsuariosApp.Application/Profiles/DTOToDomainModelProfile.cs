﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosApp.Application.Helpers;
using UsuariosApp.Application.Models.Requests;
using UsuariosApp.Domain.Models;

namespace UsuariosApp.Application.Profiles
{
    /// <summary>
    /// Mapeamento de dtos para modelos de domínio
    /// </summary>
    public class DTOToDomainModelProfile : Profile
    {
        public DTOToDomainModelProfile()
        {
            CreateMap<CriarContaRequestDTO, Usuario>()
                .AfterMap((dto, model) =>
                {
                    model.Id = Guid.NewGuid();
                    model.Senha = Sha1Encrypt.Encrypt(dto.Senha);
                    model.DataHoraCriacao = DateTime.Now;
                });
        }
    }
}
