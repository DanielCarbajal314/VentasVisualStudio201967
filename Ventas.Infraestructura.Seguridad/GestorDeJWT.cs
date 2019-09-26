using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Servicios.Interfacez.Respuestas;

namespace Ventas.Infraestructura.Seguridad
{
    public class GestorDeJWT
    {
        private static readonly string LLAVE_HASH = "HolaDesdeCraftech";
        private IJwtEncoder encoder;
        private JwtDecoder decoder;

        public GestorDeJWT()
        {
            this.encoder = this.generarEncoder();
            this.decoder = this.generarDecoder();
        }

        public string CrearToken(Session session)
        {
            return encoder.Encode(session, LLAVE_HASH);
        }
        public Session SacarSessionDesdeElToken(string token)
        {
            try
            {
                return decoder.DecodeToObject<Session>(token);
            }
            catch (JsonReaderException)
            {
                throw new Exception("El token esta mal formado");
            }
            catch (TokenExpiredException)
            {
                throw new Exception("Su session ha expirado");
            }
            catch (SignatureVerificationException)
            {
                throw new Exception("Su token es invalido");
            }
        }

        private IJwtEncoder generarEncoder()
        {
            IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
            IJsonSerializer serializer = new JsonNetSerializer();
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            return new JwtEncoder(algorithm, serializer, urlEncoder);
        }

        private JwtDecoder generarDecoder()
        {
            IJsonSerializer serializer = new JsonNetSerializer();
            IDateTimeProvider provider = new UtcDateTimeProvider();
            IJwtValidator validator = new JwtValidator(serializer, provider);
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            return new JwtDecoder(serializer, validator, urlEncoder);
        }

    }
}
