using SimpleInjector;
using Sistema.Application.Implementations.Entity;
using Sistema.Application.Implementations.Financeiro;
using Sistema.Application.Implementations.Geral;
using Sistema.Application.Interfaces.Entity;
using Sistema.Application.Interfaces.Financeiro;
using Sistema.Application.Interfaces.Geral;
using Sistema.Domain.Interfaces.Repository.Entity;
using Sistema.Domain.Interfaces.Repository.Financeiro;
using Sistema.Domain.Interfaces.Repository.Geral;
using Sistema.Domain.Interfaces.Service.Entity;
using Sistema.Domain.Interfaces.Service.Financeiro;
using Sistema.Domain.Interfaces.Service.Geral;
using Sistema.Repository.Implementations.Entity;
using Sistema.Repository.Implementations.Financeiro;
using Sistema.Repository.Implementations.Geral;
using Sistema.Service.Implementations.Entity;
using Sistema.Service.Implementations.Financeiro;
using Sistema.Service.Implementations.Geral;

namespace Sistema.Framework
{
    public static class Injections
    {
        public static Container GetContainerRegisted()
        {
            Container container = new Container();

            container.RegisterSingleton<EntidadeRepository, EntidadeRepositoryImp>();
            container.RegisterSingleton<EntidadeService, EntidadeServiceImp>();
            container.RegisterSingleton<EntidadeApp, EntidadeAppImp>();

            container.RegisterSingleton<ContactoRepository, ContactoRepositoryImp>();
            container.RegisterSingleton<ContactoService, ContactoServiceImp>();
            container.RegisterSingleton<ContactoApp, ContactoAppImp>();

            container.RegisterSingleton<DocumentoEntidadeRepository, DocumentoEntidadeRepositoryImp>();
            container.RegisterSingleton<DocumentoEntidadeService,    DocumentoEntidadeServiceImp>();
            container.RegisterSingleton<DocumentoEntidadeApp,        DocumentoEntidadeAppImp>();

            container.RegisterSingleton<EntidadePessoaRepository, EntidadePessoaRepositoryImp>();
            container.RegisterSingleton<EntidadePessoaService,    EntidadePessoaServiceImp>();
            container.RegisterSingleton<EntidadePessoaApp, EntidadePessoaAppImp>();

            container.RegisterSingleton<FornecedorRepository, FornecedorRepositoryImp>();
            container.RegisterSingleton<FornecedorService,    FornecedorServiceImp>();
            container.RegisterSingleton<FornecedorApp, FornecedorAppImp>();

            container.RegisterSingleton<HabilitacaoRepository, HabilitacaoRepositoryImp>();
            container.RegisterSingleton<HabilitacaoService,    HabilitacaoServiceImp>();
            container.RegisterSingleton<HabilitacaoApp,        HabilitacaoAppImp>();

            container.RegisterSingleton<LocalidadeRepository, LocalidadeRepositoryImp>();
            container.RegisterSingleton<LocalidadeService,    LocalidadeServiceImp>();
            container.RegisterSingleton<LocalidadeApp, LocalidadeAppImp>();

            container.RegisterSingleton<ProfissaoRepository, ProfissaoRepositoryImp>();
            container.RegisterSingleton<ProfissaoService,    ProfissaoServiceImp>();
            container.RegisterSingleton<ProfissaoApp, ProfissaoAppImp>();

            container.RegisterSingleton<TipoContactoRepository, TipoContactoRepositoryImp>();
            container.RegisterSingleton<TipoContactoService,    TipoContactoServiceImp>();
            container.RegisterSingleton<TipoContactoApp, TipoContactoAppImp>();

            container.RegisterSingleton<TipoDocumentoEntidadeRepository, TipoDocumentoEntidadeRepositoryImp>();
            container.RegisterSingleton<TipoDocumentoEntidadeService,    TipoDocumentoEntidadeServiceImp>();
            container.RegisterSingleton<TipoDocumentoEntidadeApp, TipoDocumentoEntidadeAppImp>();

            container.RegisterSingleton<PaisRepository, PaisRepositoryImp>();
            container.RegisterSingleton<PaisService,    PaisServiceImp>();
            container.RegisterSingleton<PaisApp,        PaisAppImp>();

            container.RegisterSingleton<BancoRepository, BancoRepositoryImp>();
            container.RegisterSingleton<BancoService,    BancoServiceImp>();
            container.RegisterSingleton<BancoApp,        BancoAppImp>();


            container.RegisterSingleton<ContaBancariaRepository, ContaBancariaRepositoryImp>();
            container.RegisterSingleton<ContaBancariaService,    ContaBancariaServiceImp>();
            container.RegisterSingleton<ContaBancariaApp,        ContaBancariaAppImp>();

            return container;
        }

        public static TypeForm GetFormRegisted<TypeForm>() where TypeForm : class
        {
            Container container = GetContainerRegisted();
            return container.GetInstance<TypeForm>();
        }
    }
}
