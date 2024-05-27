using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ChocoAmigoAPI.Domain.Entities
{
    public class ParticipanteGrupo
    {
        public ParticipanteGrupo(int usuarioId, int grupoId)
        {
            UsuarioId = usuarioId;
            GrupoId = grupoId;
        }

        public ParticipanteGrupo(int participantesGrupoId, int usuarioId, int grupoId)
        {
            ParticipantesGrupoId = participantesGrupoId;
            UsuarioId = usuarioId;
            GrupoId = grupoId;
        }

        public int ParticipantesGrupoId { get; private set; }
        public int UsuarioId { get; private set; }
        public int GrupoId { get; private set; }

        public Grupo Grupo { get; private set; }
        public Usuario Usuario { get; private set; }

    };
}
