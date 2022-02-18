using ErpBS100;
using Primavera.Extensibility.Engine;
using StdBE100;
using StdPlatBS100;
using System;
using TRTv10.Disposable;

namespace TRTv10.Engine
{
    internal sealed class PriEngine : DisposableBase
    {
        #region IDisposable Members

        protected override void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called
            if (!Disposed)
            {
            }

            // Dispose on base class
            base.Dispose(disposing);
        }

        #endregion

        #region Singleton pattern

        // .NET guarantees thread safety for static initialization
        private static readonly PriEngine EngineInstance = new PriEngine();

        /// <summary>
        ///     Private constructor
        /// </summary>
        private PriEngine()
        {
        }

        public static PriEngine CreatContext(string company, string user, string password)
        {
            var objAplConf = new StdBSConfApl();
            var plataforma = new StdPlatBS();
            var motorLe = new ErpBS();
            StdBETipos.EnumTipoPlataforma objTipoPlataforma;

            //Alterar transtar e' profissional
            objTipoPlataforma = StdBETipos.EnumTipoPlataforma.tpProfissional;
            objAplConf.Instancia = "Default";
            objAplConf.AbvtApl = "ERP";
            objAplConf.PwdUtilizador = password;
            objAplConf.Utilizador = user;
            objAplConf.LicVersaoMinima = "10.00";

            var objStdTransac = new StdBETransaccao();

            try
            {
                plataforma.AbrePlataformaEmpresa(company, objStdTransac, objAplConf, objTipoPlataforma);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (plataforma.Inicializada)
            {
                motorLe.AbreEmpresaTrabalho(objTipoPlataforma, company, user, password, 
                    StdBETipos.EmunTipoLigacao.desktop, objStdTransac);
                //motorLe.AbreEmpresaTrabalho(objTipoPlataforma, company, user, password, objStdTransac, "DEFAULT");

                // Use this service to trigger the API events.
                var service = new ExtensibilityService();

                // Suppress all message box events from the API.
                // Plataforma.ExtensibilityLogger.AllowInteractivity = false;
                service.Initialize(motorLe);

                // Check if service is operational
                if (service.IsOperational)
                    // Inshore that all extensions are loaded.
                    service.LoadExtensions();

                Platform = plataforma;
                Engine = motorLe;

                EngineStatus = true;
            }

            return EngineInstance;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     The platform
        /// </summary>
        public static StdPlatBS Platform { get; set; }

        /// <summary>
        ///     The engine that allows access to the modules.
        /// </summary>
        public static ErpBS Engine { get; set; }

        /// <summary>
        ///     The engine status 0 - Fail | 1 - OK
        /// </summary>
        public static bool EngineStatus { get; private set; }

        #endregion
    }
}
