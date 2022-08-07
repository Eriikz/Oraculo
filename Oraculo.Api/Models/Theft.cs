using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oraculo.Api.Models
{
    [Table("Theft")]
    public class Theft
    {
        [Key]
        [Display(Name = "Num_bo")]
        [Column("Num_bo")]
        public double Num_bo { get; set; }
        [Column("Type")]
        public string Type { get; set; }
        [Column("Ano_bo")]
        public int Ano_bo { get; set; }
        [MaxLength(15)]
        [Column("Numero_boletim")]
        public string Numero_boletim { get; set; }
        [Column("Bo_iniciado")]
        public DateTime Bo_iniciado { get; set; }
        [Column("Bo_emitido")]
        public DateTime Bo_emitido { get; set; }
        [Column("Dataocorrencia")]
        public DateTime Dataocorrencia { get; set; }
        [Column("Horaocorrencia")]
        public DateTime Horaocorrencia { get; set; }
        [MaxLength(15)]
        [Column("Peridoocorrencia")]
        public string Peridoocorrencia { get; set; }
        [Column("Datacomunicacao")]
        public DateTime Datacomunicacao { get; set; }
        [Column("Dataelaboracao")]
        public DateTime Dataelaboracao { get; set; }
        [MaxLength(15)]
        [Column("Bo_autoria")]
        public string Bo_autoria { get; set; }
        [MaxLength(10)]
        [Column("Flagrante")]
        public string Flagrante { get; set; }
        [MaxLength(40)]
        [Column("Numero_boletim_principal")]
        public string Numero_boletim_principal { get; set; }
        [MaxLength(90)]
        [Column("Logradouro")]
        public string Logradouro { get; set; }
        [Column("Numero")]
        public double Numero { get; set; }
        [MaxLength(90)]
        [Column("Bairro")]
        public string Bairro { get; set; }
        [MaxLength(90)]
        [Column("Cidade")]
        public string Cidade { get; set; }
        [MaxLength(02)]
        [Column("Uf")]
        public string Uf { get; set; }
        [MaxLength(50)]
        [Column("Latitude")]
        public string Latitude { get; set; }
        [MaxLength(50)]
        [Column("Longitude")]
        public string Longitude { get; set; }
        [MaxLength(50)]
        [Column("Descricaolocal")]
        public string Descricaolocal { get; set; }
        [MaxLength(50)]
        [Column("Exame")]
        public string Exame { get; set; }
        [MaxLength(90)]
        [Column("Solucao")]
        public string Solucao { get; set; }
        [MaxLength(90)]
        [Column("Delegacia_nome")]
        public string Delegacia_nome { get; set; }
        [MaxLength(90)]
        [Column("Delegacia_circunscricao")]
        public string Delegacia_circunscricao { get; set; }
        [MaxLength(50)]
        [Column("Especie")]
        public string Especie { get; set; }
        [MaxLength(90)]
        [Column("Rubrica")]
        public string Rubrica { get; set; }
        [MaxLength(50)]
        [Column("Desdobramento")]
        public string Desdobramento { get; set; }
        [MaxLength(50)]
        [Column("Status")]
        public string Status { get; set; }
        [MaxLength(50)]
        [Column("Tipopessoa")]
        public string Tipopessoa { get; set; }
        [MaxLength(50)]
        [Column("Vitimafatal")]
        public string Vitimafatal { get; set; }
        [MaxLength(50)]
        [Column("Naturalidade")]
        public string Naturalidade { get; set; }
        [MaxLength(50)]
        [Column("Nacionalidade")]
        public string Nacionalidade { get; set; }
        [MaxLength(15)]
        [Column("Sexo")]
        public string Sexo { get; set; }
        [Column("Datanascimento")]
        public DateTime Datanascimento { get; set; }
        [Column("Idade")]
        public int Idade { get; set; }
        [MaxLength(20)]
        [Column("Estadocivil")]
        public string Estadocivil { get; set; }
        [MaxLength(20)]
        [Column("Profissao")]
        public string Profissao { get; set; }
        [MaxLength(20)]
        [Column("Grauinstrucao")]
        public string Grauinstrucao { get; set; }
        [MaxLength(50)]
        [Column("Corcutis")]
        public string Corcutis { get; set; }
        [MaxLength(50)]
        [Column("Naturezavinculada")]
        public string Naturezavinculada { get; set; }
        [MaxLength(50)]
        [Column("Tipovinculo")]
        public string Tipovinculo { get; set; }
        [MaxLength(50)]
        [Column("Relacionamento")]
        public string Relacionamento { get; set; }
        [MaxLength(50)]
        [Column("Parentesco")]
        public string Parentesco { get; set; }
        [MaxLength(10)]
        [Column("Placa_veiculo")]
        public string Placa_veiculo { get; set; }
        [MaxLength(02)]
        [Column("Uf_veiculo")]
        public string Uf_veiculo { get; set; }
        [MaxLength(50)]
        [Column("Cidade_veiculo")]
        public string Cidade_veiculo { get; set; }
        [MaxLength(20)]
        [Column("Descr_cor_veiculo")]
        public string Descr_cor_veiculo { get; set; }
        [MaxLength(20)]
        [Column("Descr_marca_veiculo")]
        public string Descr_marca_veiculo { get; set; }
        [Column("Ano_fabricacao")]
        public int Ano_fabricacao { get; set; }
        [Column("Ano_modelo")]
        public int Ano_modelo { get; set; }
        [MaxLength(50)]
        [Column("Descr_tipo_veiculo")]
        public string Descr_tipo_veiculo { get; set; }
        [MaxLength(10)]
        [Column("Quant_celular")]
        public string Quant_celular { get; set; }
        [MaxLength(50)]
        [Column("Marca_celular")]
        public string Marca_celular { get; set; }
    }
}
