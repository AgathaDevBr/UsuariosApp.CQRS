using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosApp.Application.Models.Producers
{
    public class UsuarioMessageDTO
    {
        public TipoMensagem? TipoMensagem { get; set; }
        public DateTime? DataHora { get; set; }
        public Guid? IdUsuario { get; set; }
        public string? NomeUsuario { get; set; }
        public string? Email { get; set; }
    }
    public enum TipoMensagem 
    { 
        CriacaoDeConta = 1,
        RecuperacaoDeSenha = 2
    }

}
