using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

class Program
{
    static void Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();
        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var context = services.GetRequiredService<AppDbContext>();

            var alunoController = new AlunoController(context);
            var cursoController = new CursoController(context);
            var enderecoController = new EnderecoController(context);
            var dadosDemograficosController = new DadosDemograficosController(context);
            var situacaoAlunoController = new SituacaoAlunoController(context);
            var situacaoProfissionalController = new SituacaoProfissionalController(context);
            var acessoTecnologiaController = new AcessoTecnologiaController(context);

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Escolha uma opção para listar:");
                Console.WriteLine("1 - Alunos");
                Console.WriteLine("2 - Cursos");
                Console.WriteLine("3 - Endereços");
                Console.WriteLine("4 - Dados Demográficos");
                Console.WriteLine("5 - Situações de Aluno");
                Console.WriteLine("6 - Situações Profissionais");
                Console.WriteLine("7 - Acessos à Tecnologia");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        alunoController.ListarAlunos();
                        break;
                    case "2":
                        cursoController.ListarCursos();
                        break;
                    case "3":
                        enderecoController.ListarEnderecos();
                        break;
                    case "4":
                        dadosDemograficosController.ListarDadosDemograficos();
                        break;
                    case "5":
                        situacaoAlunoController.ListarSituacoesAlunos();
                        break;
                    case "6":
                        situacaoProfissionalController.ListarSituacoesProfissionais();
                        break;
                    case "7":
                        acessoTecnologiaController.ListarAcessoTecnologias();
                        break;
                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }

    static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                var connectionString = context.Configuration.GetConnectionString("DefaultConnection");
                services.AddDbContext<AppDbContext>(options =>
                    options.UseNpgsql(connectionString)); // UseNpgsql para PostgreSQL

                services.AddTransient<AlunoController>();
                services.AddTransient<CursoController>();
                services.AddTransient<EnderecoController>();
                services.AddTransient<DadosDemograficosController>();
                services.AddTransient<SituacaoAlunoController>();
                services.AddTransient<SituacaoProfissionalController>();
                services.AddTransient<AcessoTecnologiaController>();
            });
}
