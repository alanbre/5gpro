using _5gpro.Daos;
using MySql.Data.MySqlClient;
using System;
using System.IO;

namespace _5gpro.Funcoes
{
    class DatabaseUpdate
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();
        public bool CriarTabelasSeNaoExistirem()
        {
            try
            {
                Connect.AbrirConexaoSemBase();
                var mySqlScript = new MySqlScript(Connect.Conexao, CreateTableSQL());
                mySqlScript.Execute();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                return false;
            }
            finally
            {
                Connect.FecharConexao();
            }
        }
        private string CreateTableSQL()
        {
            string create = @"-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema 5gprodatabase
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema 5gprodatabase
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `5gprodatabase` DEFAULT CHARACTER SET utf8 ;
USE `5gprodatabase` ;

-- -----------------------------------------------------
-- Table `5gprodatabase`.`pais`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`pais` (
  `idpais` INT(11) NOT NULL,
  `nome` VARCHAR(45) NULL DEFAULT NULL,
  `sigla` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`idpais`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`estado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`estado` (
  `idestado` INT(11) NOT NULL,
  `nome` VARCHAR(45) NULL DEFAULT NULL,
  `uf` CHAR(2) NULL DEFAULT NULL,
  `idpais` INT(11) NOT NULL,
  PRIMARY KEY (`idestado`),
  INDEX `fk_estado_pais1_idx` (`idpais` ASC) VISIBLE,
  CONSTRAINT `fk_estado_pais1`
    FOREIGN KEY (`idpais`)
    REFERENCES `5gprodatabase`.`pais` (`idpais`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`cidade`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`cidade` (
  `idcidade` INT(11) NOT NULL,
  `nome` VARCHAR(45) NULL DEFAULT NULL,
  `idestado` INT(11) NOT NULL,
  PRIMARY KEY (`idcidade`),
  INDEX `fk_cidade_estado1_idx` (`idestado` ASC) VISIBLE,
  CONSTRAINT `fk_cidade_estado1`
    FOREIGN KEY (`idestado`)
    REFERENCES `5gprodatabase`.`estado` (`idestado`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`configuracao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`configuracao` (
  `idconfiguracao` INT(11) NOT NULL AUTO_INCREMENT,
  `variavel` VARCHAR(200) NULL DEFAULT NULL,
  `valor` VARCHAR(200) NULL DEFAULT NULL,
  PRIMARY KEY (`idconfiguracao`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`grupo_usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`grupo_usuario` (
  `idgrupousuario` INT(11) NOT NULL,
  `nome` VARCHAR(60) NULL DEFAULT NULL,
  PRIMARY KEY (`idgrupousuario`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`unimedida`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`unimedida` (
  `idunimedida` INT(11) NOT NULL AUTO_INCREMENT,
  `sigla` VARCHAR(45) NULL DEFAULT NULL,
  `descricao` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`idunimedida`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`grupoitem`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`grupoitem` (
  `idgrupoitem` INT NOT NULL,
  `nome` VARCHAR(150) NOT NULL,
  PRIMARY KEY (`idgrupoitem`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`subgrupoitem`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`subgrupoitem` (
  `idsubgrupoitem` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(150) NOT NULL,
  `idgrupoitem` INT NOT NULL,
  `codigo` INT(11) NOT NULL,
  PRIMARY KEY (`idsubgrupoitem`),
  INDEX `fk_subgrupoitem_GrupoItem1_idx` (`idgrupoitem` ASC) VISIBLE,
  CONSTRAINT `fk_subgrupoitem_GrupoItem1`
    FOREIGN KEY (`idgrupoitem`)
    REFERENCES `5gprodatabase`.`grupoitem` (`idgrupoitem`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`item`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`item` (
  `iditem` INT(11) NOT NULL,
  `descitem` VARCHAR(45) NULL DEFAULT NULL,
  `denominacaocompra` VARCHAR(45) NULL DEFAULT NULL,
  `tipo` VARCHAR(45) NULL DEFAULT NULL,
  `referencia` VARCHAR(45) NULL DEFAULT NULL,
  `valorentrada` DECIMAL(15,2) NULL DEFAULT NULL,
  `valorsaida` DECIMAL(15,2) NULL DEFAULT NULL,
  `estoquenecessario` DECIMAL(10,0) NULL DEFAULT NULL,
  `idunimedida` INT(11) NOT NULL,
  `idsubgrupoitem` INT NOT NULL,
  `quantidade` DECIMAL NOT NULL,
  `custo` DECIMAL(15,2) NULL,
  PRIMARY KEY (`iditem`),
  INDEX `fk_item_unimedida1_idx` (`idunimedida` ASC) VISIBLE,
  INDEX `fk_item_subgrupoitem1_idx` (`idsubgrupoitem` ASC) VISIBLE,
  CONSTRAINT `fk_item_unimedida1`
    FOREIGN KEY (`idunimedida`)
    REFERENCES `5gprodatabase`.`unimedida` (`idunimedida`),
  CONSTRAINT `fk_item_subgrupoitem1`
    FOREIGN KEY (`idsubgrupoitem`)
    REFERENCES `5gprodatabase`.`subgrupoitem` (`idsubgrupoitem`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`grupopessoa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`grupopessoa` (
  `idgrupopessoa` INT NOT NULL,
  `nome` VARCHAR(150) NOT NULL,
  PRIMARY KEY (`idgrupopessoa`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`subgrupopessoa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`subgrupopessoa` (
  `idsubgrupopessoa` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(150) NOT NULL,
  `idgrupopessoa` INT NOT NULL,
  `codigo` INT(11) NOT NULL,
  PRIMARY KEY (`idsubgrupopessoa`),
  INDEX `fk_subgrupopessoa_grupopessoa1_idx` (`idgrupopessoa` ASC) VISIBLE,
  CONSTRAINT `fk_subgrupopessoa_grupopessoa1`
    FOREIGN KEY (`idgrupopessoa`)
    REFERENCES `5gprodatabase`.`grupopessoa` (`idgrupopessoa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`pessoa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`pessoa` (
  `idpessoa` INT(11) NOT NULL,
  `nome` VARCHAR(255) NOT NULL,
  `fantasia` VARCHAR(255) NULL DEFAULT NULL,
  `rua` VARCHAR(150) NULL DEFAULT NULL,
  `numero` VARCHAR(10) NULL DEFAULT NULL,
  `bairro` VARCHAR(45) NULL DEFAULT NULL,
  `complemento` VARCHAR(45) NULL DEFAULT NULL,
  `cpf` VARCHAR(11) NULL DEFAULT NULL,
  `cnpj` VARCHAR(14) NULL DEFAULT NULL,
  `endereco` VARCHAR(45) NULL DEFAULT NULL,
  `telefone` VARCHAR(45) NULL DEFAULT NULL,
  `email` VARCHAR(100) NULL DEFAULT NULL,
  `idcidade` INT(11) NOT NULL,
  `tipo_pessoa` CHAR(1) NULL DEFAULT NULL,
  `idsubgrupopessoa` INT NOT NULL,
  `atuacao` VARCHAR(45) NOT NULL,
  `situacao` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idpessoa`),
  INDEX `fk_pessoa_cidade1_idx` (`idcidade` ASC) VISIBLE,
  INDEX `fk_pessoa_subgrupopessoa1_idx` (`idsubgrupopessoa` ASC) VISIBLE,
  CONSTRAINT `fk_pessoa_cidade1`
    FOREIGN KEY (`idcidade`)
    REFERENCES `5gprodatabase`.`cidade` (`idcidade`),
  CONSTRAINT `fk_pessoa_subgrupopessoa1`
    FOREIGN KEY (`idsubgrupopessoa`)
    REFERENCES `5gprodatabase`.`subgrupopessoa` (`idsubgrupopessoa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`notafiscal`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`notafiscal` (
  `idnotafiscal` INT(11) NOT NULL,
  `data_emissao` DATETIME NOT NULL,
  `data_entradasaida` DATETIME NOT NULL,
  `tiponf` CHAR(1) NOT NULL,
  `valor_total_itens` DECIMAL(10,2) NULL DEFAULT NULL,
  `valor_documento` DECIMAL(10,2) NULL DEFAULT NULL,
  `desconto_total_itens` DECIMAL(10,2) NULL DEFAULT NULL,
  `desconto_documento` DECIMAL(10,2) NULL DEFAULT NULL,
  `idpessoa` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`idnotafiscal`),
  INDEX `fk_notafiscal_pessoa1_idx` (`idpessoa` ASC) VISIBLE,
  CONSTRAINT `fk_notafiscal_pessoa1`
    FOREIGN KEY (`idpessoa`)
    REFERENCES `5gprodatabase`.`pessoa` (`idpessoa`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`notafiscal_has_item`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`notafiscal_has_item` (
  `idnotafiscal` INT(11) NOT NULL,
  `iditem` INT(11) NOT NULL,
  `quantidade` DECIMAL(10,2) NULL DEFAULT NULL,
  `valor_unitario` DECIMAL(10,2) NULL DEFAULT NULL,
  `valor_total` DECIMAL(10,2) NULL DEFAULT NULL,
  `desconto_porc` DECIMAL(10,2) NULL DEFAULT NULL,
  `desconto` DECIMAL(10,2) NULL DEFAULT NULL,
  PRIMARY KEY (`idnotafiscal`, `iditem`),
  INDEX `fk_notafiscal_has_item_item1_idx` (`iditem` ASC) VISIBLE,
  INDEX `fk_notafiscal_has_item_notafiscal1_idx` (`idnotafiscal` ASC) VISIBLE,
  CONSTRAINT `fk_notafiscal_has_item_item1`
    FOREIGN KEY (`iditem`)
    REFERENCES `5gprodatabase`.`item` (`iditem`),
  CONSTRAINT `fk_notafiscal_has_item_notafiscal1`
    FOREIGN KEY (`idnotafiscal`)
    REFERENCES `5gprodatabase`.`notafiscal` (`idnotafiscal`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`orcamento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`orcamento` (
  `idorcamento` INT(11) NOT NULL,
  `data_cadastro` DATE NOT NULL,
  `data_validade` DATE NULL DEFAULT NULL,
  `valor_total_itens` DECIMAL(10,2) NULL DEFAULT NULL,
  `valor_orcamento` DECIMAL(10,2) NULL DEFAULT NULL,
  `desconto_total_itens` DECIMAL(10,2) NULL DEFAULT NULL,
  `desconto_orcamento` DECIMAL(10,2) NULL DEFAULT NULL,
  `idnotafiscal` INT(11) NULL,
  `idpessoa` INT(11) NULL,
  PRIMARY KEY (`idorcamento`),
  INDEX `fk_orcamento_notafiscal1_idx` (`idnotafiscal` ASC) VISIBLE,
  INDEX `fk_orcamento_pessoa1_idx` (`idpessoa` ASC) VISIBLE,
  CONSTRAINT `fk_orcamento_notafiscal1`
    FOREIGN KEY (`idnotafiscal`)
    REFERENCES `5gprodatabase`.`notafiscal` (`idnotafiscal`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_orcamento_pessoa1`
    FOREIGN KEY (`idpessoa`)
    REFERENCES `5gprodatabase`.`pessoa` (`idpessoa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`orcamento_has_item`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`orcamento_has_item` (
  `idorcamento` INT(11) NOT NULL,
  `iditem` INT(11) NOT NULL,
  `quantidade` DECIMAL(10,2) NULL DEFAULT NULL,
  `valor_unitario` DECIMAL(10,2) NULL DEFAULT NULL,
  `valor_total` DECIMAL(10,2) NULL DEFAULT NULL,
  `desconto_porc` DECIMAL(10,2) NULL DEFAULT NULL,
  `desconto` DECIMAL(10,2) NULL DEFAULT NULL,
  PRIMARY KEY (`idorcamento`, `iditem`),
  INDEX `fk_orcamento_has_item_item1_idx` (`iditem` ASC) VISIBLE,
  INDEX `fk_orcamento_has_item_orcamento1_idx` (`idorcamento` ASC) VISIBLE,
  CONSTRAINT `fk_orcamento_has_item_item1`
    FOREIGN KEY (`iditem`)
    REFERENCES `5gprodatabase`.`item` (`iditem`),
  CONSTRAINT `fk_orcamento_has_item_orcamento1`
    FOREIGN KEY (`idorcamento`)
    REFERENCES `5gprodatabase`.`orcamento` (`idorcamento`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`permissao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`permissao` (
  `idpermissao` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NULL DEFAULT NULL,
  `codigo` VARCHAR(60) NOT NULL,
  PRIMARY KEY (`idpermissao`),
  UNIQUE INDEX `codigo_UNIQUE` (`codigo` ASC) VISIBLE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`permissao_has_grupo_usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`permissao_has_grupo_usuario` (
  `idpermissao` INT(11) NOT NULL,
  `idgrupousuario` INT(11) NOT NULL,
  `nivel` INT(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`idpermissao`, `idgrupousuario`),
  INDEX `fk_permissao_has_grupo_usuario_grupo_usuario1_idx` (`idgrupousuario` ASC) VISIBLE,
  INDEX `fk_permissao_has_grupo_usuario_permissao1_idx` (`idpermissao` ASC) VISIBLE,
  CONSTRAINT `fk_permissao_has_grupo_usuario_grupo_usuario1`
    FOREIGN KEY (`idgrupousuario`)
    REFERENCES `5gprodatabase`.`grupo_usuario` (`idgrupousuario`),
  CONSTRAINT `fk_permissao_has_grupo_usuario_permissao1`
    FOREIGN KEY (`idpermissao`)
    REFERENCES `5gprodatabase`.`permissao` (`idpermissao`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`usuario` (
  `idusuario` INT(11) NOT NULL,
  `nome` VARCHAR(40) NOT NULL,
  `sobrenome` VARCHAR(50) NULL DEFAULT NULL,
  `senha` VARCHAR(255) NOT NULL,
  `email` VARCHAR(60) NULL DEFAULT NULL,
  `telefone` VARCHAR(45) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NULL DEFAULT NULL,
  `idgrupousuario` INT(11) NOT NULL,
  PRIMARY KEY (`idusuario`),
  INDEX `fk_usuario_grupo_usuario1_idx` (`idgrupousuario` ASC) VISIBLE,
  CONSTRAINT `fk_usuario_grupo_usuario1`
    FOREIGN KEY (`idgrupousuario`)
    REFERENCES `5gprodatabase`.`grupo_usuario` (`idgrupousuario`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`logado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`logado` (
  `idusuario` INT(11) NOT NULL,
  `mac` VARCHAR(45) NULL,
  `nomepc` VARCHAR(45) NULL,
  `ipdopc` VARCHAR(45) NULL,
  `data_update` DATETIME NULL,
  PRIMARY KEY (`idusuario`),
  INDEX `fk_logado_usuario1_idx` (`idusuario` ASC) VISIBLE,
  CONSTRAINT `fk_logado_usuario1`
    FOREIGN KEY (`idusuario`)
    REFERENCES `5gprodatabase`.`usuario` (`idusuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`operacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`operacao` (
  `idoperacao` INT NOT NULL,
  `nome` VARCHAR(45) NOT NULL,
  `descricao` VARCHAR(100) NULL,
  `condicao` VARCHAR(45) NULL,
  `desconto` DECIMAL(10,2) NULL,
  `entrada` DECIMAL(10,2) NULL,
  `acrescimo` DECIMAL(10,2) NULL,
  PRIMARY KEY (`idoperacao`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`parcelaoperacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`parcelaoperacao` (
  `idparcelaoperacao` INT NOT NULL AUTO_INCREMENT,
  `numero` INT NULL,
  `dias` INT NULL,
  `idoperacao` INT NOT NULL,
  PRIMARY KEY (`idparcelaoperacao`),
  INDEX `fk_parcelaoperacao_operacao1_idx` (`idoperacao` ASC) VISIBLE,
  CONSTRAINT `fk_parcelaoperacao_operacao1`
    FOREIGN KEY (`idoperacao`)
    REFERENCES `5gprodatabase`.`operacao` (`idoperacao`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`lock`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`lock` (
  `idlock` INT NOT NULL AUTO_INCREMENT,
  `tabela` VARCHAR(30) NULL,
  `codigo_registro` INT NULL,
  `idusuario` INT(11) NOT NULL,
  PRIMARY KEY (`idlock`),
  INDEX `fk_lock_logado1_idx` (`idusuario` ASC) VISIBLE,
  CONSTRAINT `fk_lock_logado1`
    FOREIGN KEY (`idusuario`)
    REFERENCES `5gprodatabase`.`logado` (`idusuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`formapagamento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`formapagamento` (
  `idformapagamento` INT NOT NULL,
  `nome` VARCHAR(60) NOT NULL,
  PRIMARY KEY (`idformapagamento`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`conta_receber`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`conta_receber` (
  `idconta_receber` INT NOT NULL,
  `data_cadastro` DATETIME NOT NULL,
  `idoperacao` INT NOT NULL,
  `valor_original` DECIMAL(10,2) NOT NULL,
  `multa` DECIMAL(10,2) NOT NULL,
  `juros` DECIMAL(10,2) NOT NULL,
  `acrescimo` DECIMAL(10,2) NOT NULL,
  `valor_final` DECIMAL(10,2) NOT NULL,
  `idpessoa` INT(11) NOT NULL,
  `desconto` DECIMAL(10,2) NULL,
  `situacao` VARCHAR(45) NOT NULL,
  `data_conta` DATETIME NOT NULL,
  `descricao` VARCHAR(200) NULL,
  PRIMARY KEY (`idconta_receber`),
  INDEX `fk_conta_receber_operacao1_idx` (`idoperacao` ASC) VISIBLE,
  INDEX `fk_conta_receber_pessoa1_idx` (`idpessoa` ASC) VISIBLE,
  CONSTRAINT `fk_conta_receber_operacao1`
    FOREIGN KEY (`idoperacao`)
    REFERENCES `5gprodatabase`.`operacao` (`idoperacao`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_conta_receber_pessoa1`
    FOREIGN KEY (`idpessoa`)
    REFERENCES `5gprodatabase`.`pessoa` (`idpessoa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`parcela_conta_receber`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`parcela_conta_receber` (
  `idparcela_conta_receber` INT NOT NULL AUTO_INCREMENT,
  `sequencia` INT NOT NULL,
  `data_vencimento` DATE NOT NULL,
  `valor` DECIMAL(10,2) NOT NULL,
  `multa` DECIMAL(10,2) NOT NULL,
  `juros` DECIMAL(10,2) NOT NULL,
  `acrescimo` DECIMAL(10,2) NOT NULL,
  `valor_final` DECIMAL(10,2) NOT NULL,
  `data_quitacao` DATETIME NULL,
  `idconta_receber` INT NOT NULL,
  `idformapagamento` INT NULL,
  `desconto` DECIMAL(10,2) NULL,
  `situacao` VARCHAR(45) NOT NULL,
  `descricao` VARCHAR(200) NULL,
  PRIMARY KEY (`idparcela_conta_receber`),
  INDEX `fk_parcela_conta_receber_conta_receber1_idx` (`idconta_receber` ASC) VISIBLE,
  INDEX `fk_parcela_conta_receber_formapagamento1_idx` (`idformapagamento` ASC) VISIBLE,
  CONSTRAINT `fk_parcela_conta_receber_conta_receber1`
    FOREIGN KEY (`idconta_receber`)
    REFERENCES `5gprodatabase`.`conta_receber` (`idconta_receber`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_parcela_conta_receber_formapagamento1`
    FOREIGN KEY (`idformapagamento`)
    REFERENCES `5gprodatabase`.`formapagamento` (`idformapagamento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`conta_pagar`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`conta_pagar` (
  `idconta_pagar` INT NOT NULL,
  `data_cadastro` DATETIME NOT NULL,
  `valor_original` DECIMAL(10,2) NOT NULL,
  `multa` DECIMAL(10,2) NOT NULL,
  `juros` DECIMAL(10,2) NOT NULL,
  `valor_final` DECIMAL(10,2) NOT NULL,
  `idpessoa` INT(11) NOT NULL,
  `acrescimo` DECIMAL(10,2) NULL,
  `desconto` DECIMAL(10,2) NULL,
  `situacao` VARCHAR(45) NOT NULL,
  `data_conta` DATETIME NOT NULL,
  `descricao` VARCHAR(200) NULL,
  PRIMARY KEY (`idconta_pagar`),
  INDEX `fk_conta_pagar_pessoa1_idx` (`idpessoa` ASC) VISIBLE,
  CONSTRAINT `fk_conta_pagar_pessoa1`
    FOREIGN KEY (`idpessoa`)
    REFERENCES `5gprodatabase`.`pessoa` (`idpessoa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`parcela_conta_pagar`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`parcela_conta_pagar` (
  `idparcela_conta_pagar` INT NOT NULL AUTO_INCREMENT,
  `sequencia` INT NULL,
  `data_vencimento` DATE NULL,
  `valor` DECIMAL(10,2) NULL,
  `multa` DECIMAL(10,2) NULL,
  `juros` DECIMAL(10,2) NULL,
  `valor_final` DECIMAL(10,2) NULL,
  `data_quitacao` DATETIME NULL,
  `idconta_pagar` INT NOT NULL,
  `idformapagamento` INT NULL,
  `acrescimo` DECIMAL(10,2) NULL,
  `desconto` DECIMAL(10,2) NULL,
  `situacao` VARCHAR(45) NOT NULL,
  `descricao` VARCHAR(200) NULL,
  PRIMARY KEY (`idparcela_conta_pagar`),
  INDEX `fk_parcela_conta_pagar_formapagamento1_idx` (`idformapagamento` ASC) VISIBLE,
  INDEX `fk_parcela_conta_pagar_conta_pagar1_idx` (`idconta_pagar` ASC) VISIBLE,
  CONSTRAINT `fk_parcela_conta_pagar_formapagamento1`
    FOREIGN KEY (`idformapagamento`)
    REFERENCES `5gprodatabase`.`formapagamento` (`idformapagamento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_parcela_conta_pagar_conta_pagar1`
    FOREIGN KEY (`idconta_pagar`)
    REFERENCES `5gprodatabase`.`conta_pagar` (`idconta_pagar`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`registro_estoque`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`registro_estoque` (
  `idregistro_estoque` INT NOT NULL AUTO_INCREMENT,
  `tipomovimentacao` CHAR(1) NOT NULL,
  `data` DATETIME NOT NULL,
  `documento` VARCHAR(60) NOT NULL,
  `iditem` INT(11) NOT NULL,
  `quantidade` DECIMAL(10,2) NOT NULL,
  `idpessoa` INT(11) NULL,
  PRIMARY KEY (`idregistro_estoque`),
  INDEX `fk_registromovimentacao_item1_idx` (`iditem` ASC) VISIBLE,
  INDEX `fk_registro_estoque_pessoa1_idx` (`idpessoa` ASC) VISIBLE,
  CONSTRAINT `fk_registromovimentacao_item1`
    FOREIGN KEY (`iditem`)
    REFERENCES `5gprodatabase`.`item` (`iditem`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_registro_estoque_pessoa1`
    FOREIGN KEY (`idpessoa`)
    REFERENCES `5gprodatabase`.`pessoa` (`idpessoa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`nota_fiscal_terceiros`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`nota_fiscal_terceiros` (
  `idnota_fiscal_terceiros` INT NOT NULL,
  `data_emissao` DATETIME NULL,
  `data_entradasaida` DATETIME NULL,
  `tiponf` CHAR(1) NULL,
  `valor_total_itens` DECIMAL(10,2) NULL,
  `valor_documento` DECIMAL(10,2) NULL,
  `desconto_total_itens` DECIMAL(10,2) NOT NULL,
  `desconto_documento` DECIMAL(10,2) NOT NULL,
  `idpessoa` INT(11) NULL,
  PRIMARY KEY (`idnota_fiscal_terceiros`),
  INDEX `fk_nota_fiscal_terceiros_pessoa1_idx` (`idpessoa` ASC) VISIBLE,
  CONSTRAINT `fk_nota_fiscal_terceiros_pessoa1`
    FOREIGN KEY (`idpessoa`)
    REFERENCES `5gprodatabase`.`pessoa` (`idpessoa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`nota_fiscal_terceiros_has_item`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`nota_fiscal_terceiros_has_item` (
  `idnota_fiscal_terceiros` INT NOT NULL,
  `iditem` INT(11) NOT NULL,
  `quantidade` DECIMAL(10,2) NOT NULL,
  `valor_unitario` DECIMAL(10,2) NOT NULL,
  `valor_total` DECIMAL(10,2) NOT NULL,
  `desconto_porc` DECIMAL(10,2) NOT NULL,
  `desconto` DECIMAL(10,2) NOT NULL,
  PRIMARY KEY (`idnota_fiscal_terceiros`, `iditem`),
  INDEX `fk_nota_fiscal_terceiros_has_item_item1_idx` (`iditem` ASC) VISIBLE,
  INDEX `fk_nota_fiscal_terceiros_has_item_nota_fiscal_terceiros1_idx` (`idnota_fiscal_terceiros` ASC) VISIBLE,
  CONSTRAINT `fk_nota_fiscal_terceiros_has_item_nota_fiscal_terceiros1`
    FOREIGN KEY (`idnota_fiscal_terceiros`)
    REFERENCES `5gprodatabase`.`nota_fiscal_terceiros` (`idnota_fiscal_terceiros`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_nota_fiscal_terceiros_has_item_item1`
    FOREIGN KEY (`iditem`)
    REFERENCES `5gprodatabase`.`item` (`iditem`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`desintegracao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`desintegracao` (
  `iddesintegracao` INT NOT NULL,
  `iditemdesintegrado` INT(11) NOT NULL,
  `tipo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`iddesintegracao`),
  INDEX `fk_desintegracao_item1_idx` (`iditemdesintegrado` ASC) VISIBLE,
  CONSTRAINT `fk_desintegracao_item1`
    FOREIGN KEY (`iditemdesintegrado`)
    REFERENCES `5gprodatabase`.`item` (`iditem`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`resultado_desintegracao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`resultado_desintegracao` (
  `idresultado_desintegracao` INT NOT NULL AUTO_INCREMENT,
  `iddesintegracao` INT NOT NULL,
  `iditemparte` INT(11) NOT NULL,
  `porcentagem` DECIMAL(10,2) NULL,
  `quantidade` DECIMAL NULL,
  PRIMARY KEY (`idresultado_desintegracao`),
  INDEX `fk_resultado_desintegracao_desintegracao1_idx` (`iddesintegracao` ASC) VISIBLE,
  INDEX `fk_resultado_desintegracao_item1_idx` (`iditemparte` ASC) VISIBLE,
  CONSTRAINT `fk_resultado_desintegracao_desintegracao1`
    FOREIGN KEY (`iddesintegracao`)
    REFERENCES `5gprodatabase`.`desintegracao` (`iddesintegracao`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_resultado_desintegracao_item1`
    FOREIGN KEY (`iditemparte`)
    REFERENCES `5gprodatabase`.`item` (`iditem`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`caixa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`caixa` (
  `idcaixa` INT NOT NULL AUTO_INCREMENT,
  `codigo` INT NOT NULL,
  `nome` VARCHAR(50) NOT NULL,
  `aberto` TINYINT NOT NULL,
  `descricao` VARCHAR(500) NULL,
  `dataabertura` DATETIME NULL,
  `datafechamento` DATETIME NULL,
  `valorabertura` DECIMAL(10,2) NULL,
  `valorfechamento` DECIMAL(10,2) NULL,
  `idusuario` INT(11) NOT NULL,
  PRIMARY KEY (`idcaixa`),
  INDEX `fk_caixa_usuario1_idx` (`idusuario` ASC) VISIBLE,
  UNIQUE INDEX `codigo_UNIQUE` (`codigo` ASC) VISIBLE,
  CONSTRAINT `fk_caixa_usuario1`
    FOREIGN KEY (`idusuario`)
    REFERENCES `5gprodatabase`.`usuario` (`idusuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`caixa_plano_contas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`caixa_plano_contas` (
  `idcaixa_plano_contas` INT NOT NULL AUTO_INCREMENT,
  `codigo` INT NOT NULL,
  `level` INT NOT NULL,
  `paiid` INT NULL,
  `descricao` VARCHAR(45) NOT NULL,
  `codigo_completo` VARCHAR(50) NULL,
  PRIMARY KEY (`idcaixa_plano_contas`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`caixa_lancamento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`caixa_lancamento` (
  `idcaixa_lancamento` INT NOT NULL AUTO_INCREMENT,
  `data` DATETIME NOT NULL,
  `valor` DECIMAL(10,2) NOT NULL,
  `tipomovimento` TINYINT(1) UNSIGNED NOT NULL,
  `tipodocumento` TINYINT(1) UNSIGNED NOT NULL,
  `lancamento` TINYINT(1) UNSIGNED NOT NULL,
  `documento` VARCHAR(15) NULL,
  `idcaixa` INT NOT NULL,
  `idcaixa_plano_contas` INT NOT NULL,
  PRIMARY KEY (`idcaixa_lancamento`),
  INDEX `fk_caixa_entrada_caixa1_idx` (`idcaixa` ASC) VISIBLE,
  INDEX `fk_caixa_lancamento_caixa_plano_contas1_idx` (`idcaixa_plano_contas` ASC) VISIBLE,
  CONSTRAINT `fk_caixa_entrada_caixa1`
    FOREIGN KEY (`idcaixa`)
    REFERENCES `5gprodatabase`.`caixa` (`idcaixa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_caixa_lancamento_caixa_plano_contas1`
    FOREIGN KEY (`idcaixa_plano_contas`)
    REFERENCES `5gprodatabase`.`caixa_plano_contas` (`idcaixa_plano_contas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`caixa_sangria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`caixa_sangria` (
  `idcaixa_sangria` INT NOT NULL AUTO_INCREMENT,
  `data` DATETIME NOT NULL,
  `dinheiro` DECIMAL(10,2) NULL,
  PRIMARY KEY (`idcaixa_sangria`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`caixa_sangria_lancamento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`caixa_sangria_lancamento` (
  `idcaixa_sangria_lancamentos` INT NOT NULL AUTO_INCREMENT,
  `idcaixa_lancamento` INT NOT NULL,
  `idcaixa_sangria` INT NOT NULL,
  PRIMARY KEY (`idcaixa_sangria_lancamentos`),
  INDEX `fk_caixa_sangria_lancamentos_caixa_lancamentos1_idx` (`idcaixa_lancamento` ASC) VISIBLE,
  INDEX `fk_caixa_sangria_lancamentos_caixa_sangria1_idx` (`idcaixa_sangria` ASC) VISIBLE,
  CONSTRAINT `fk_caixa_sangria_lancamentos_caixa_lancamentos1`
    FOREIGN KEY (`idcaixa_lancamento`)
    REFERENCES `5gprodatabase`.`caixa_lancamento` (`idcaixa_lancamento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_caixa_sangria_lancamentos_caixa_sangria1`
    FOREIGN KEY (`idcaixa_sangria`)
    REFERENCES `5gprodatabase`.`caixa_sangria` (`idcaixa_sangria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`caixa_lancamento_car`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`caixa_lancamento_car` (
  `idcaixa_lancamento` INT NOT NULL,
  `idparcela_conta_receber` INT NOT NULL,
  INDEX `fk_caixa_lancamento_car_parcela_conta_receber1_idx` (`idparcela_conta_receber` ASC) VISIBLE,
  PRIMARY KEY (`idcaixa_lancamento`),
  CONSTRAINT `fk_caixa_lancamento_car_parcela_conta_receber1`
    FOREIGN KEY (`idparcela_conta_receber`)
    REFERENCES `5gprodatabase`.`parcela_conta_receber` (`idparcela_conta_receber`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_caixa_lancamento_car_caixa_lancamento1`
    FOREIGN KEY (`idcaixa_lancamento`)
    REFERENCES `5gprodatabase`.`caixa_lancamento` (`idcaixa_lancamento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`caixa_lancamento_cap`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`caixa_lancamento_cap` (
  `idcaixa_lancamento` INT NOT NULL,
  `idparcela_conta_pagar` INT NOT NULL,
  PRIMARY KEY (`idcaixa_lancamento`),
  INDEX `fk_caixa_lancamento_cap_parcela_conta_pagar1_idx` (`idparcela_conta_pagar` ASC) VISIBLE,
  CONSTRAINT `fk_caixa_lancamento_cap_caixa_lancamento1`
    FOREIGN KEY (`idcaixa_lancamento`)
    REFERENCES `5gprodatabase`.`caixa_lancamento` (`idcaixa_lancamento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_caixa_lancamento_cap_parcela_conta_pagar1`
    FOREIGN KEY (`idparcela_conta_pagar`)
    REFERENCES `5gprodatabase`.`parcela_conta_pagar` (`idparcela_conta_pagar`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`caixa_lancamento_sai`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`caixa_lancamento_sai` (
  `idcaixa_lancamento` INT NOT NULL,
  `idnotafiscal` INT(11) NOT NULL,
  PRIMARY KEY (`idcaixa_lancamento`),
  INDEX `fk_caixa_lancamento_sai_notafiscal1_idx` (`idnotafiscal` ASC) VISIBLE,
  CONSTRAINT `fk_table1_caixa_lancamento3`
    FOREIGN KEY (`idcaixa_lancamento`)
    REFERENCES `5gprodatabase`.`caixa_lancamento` (`idcaixa_lancamento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_caixa_lancamento_sai_notafiscal1`
    FOREIGN KEY (`idnotafiscal`)
    REFERENCES `5gprodatabase`.`notafiscal` (`idnotafiscal`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`caixa_lancamento_ent`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`caixa_lancamento_ent` (
  `idcaixa_lancamento` INT NOT NULL,
  `idnota_fiscal_terceiros` INT NOT NULL,
  PRIMARY KEY (`idcaixa_lancamento`),
  INDEX `fk_caixa_lancamento_ent_nota_fiscal_terceiros1_idx` (`idnota_fiscal_terceiros` ASC) VISIBLE,
  CONSTRAINT `fk_table1_caixa_lancamento4`
    FOREIGN KEY (`idcaixa_lancamento`)
    REFERENCES `5gprodatabase`.`caixa_lancamento` (`idcaixa_lancamento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_caixa_lancamento_ent_nota_fiscal_terceiros1`
    FOREIGN KEY (`idnota_fiscal_terceiros`)
    REFERENCES `5gprodatabase`.`nota_fiscal_terceiros` (`idnota_fiscal_terceiros`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`caixa_plano_contas_padrao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`caixa_plano_contas_padrao` (
  `idcaixa_plano_contas_padrao` INT NOT NULL,
  `compras` INT NULL,
  `contas_pagar` INT NULL,
  `descontos_concedidos` INT NULL,
  `juros_pagos` INT NULL,
  `vendas` INT NULL,
  `contas_receber` INT NULL,
  `descontos_recebidos` INT NULL,
  `juros_recebidos` INT NULL,
  PRIMARY KEY (`idcaixa_plano_contas_padrao`),
  INDEX `fk_caixa_plano_contas_padrao_caixa_plano_contas1_idx` (`compras` ASC) VISIBLE,
  INDEX `fk_caixa_plano_contas_padrao_caixa_plano_contas2_idx` (`contas_pagar` ASC) VISIBLE,
  INDEX `fk_caixa_plano_contas_padrao_caixa_plano_contas3_idx` (`descontos_concedidos` ASC) VISIBLE,
  INDEX `fk_caixa_plano_contas_padrao_caixa_plano_contas4_idx` (`juros_pagos` ASC) VISIBLE,
  INDEX `fk_caixa_plano_contas_padrao_caixa_plano_contas5_idx` (`vendas` ASC) VISIBLE,
  INDEX `fk_caixa_plano_contas_padrao_caixa_plano_contas6_idx` (`contas_receber` ASC) VISIBLE,
  INDEX `fk_caixa_plano_contas_padrao_caixa_plano_contas7_idx` (`descontos_recebidos` ASC) VISIBLE,
  INDEX `fk_caixa_plano_contas_padrao_caixa_plano_contas8_idx` (`juros_recebidos` ASC) VISIBLE,
  CONSTRAINT `fk_caixa_plano_contas_padrao_caixa_plano_contas1`
    FOREIGN KEY (`compras`)
    REFERENCES `5gprodatabase`.`caixa_plano_contas` (`idcaixa_plano_contas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_caixa_plano_contas_padrao_caixa_plano_contas2`
    FOREIGN KEY (`contas_pagar`)
    REFERENCES `5gprodatabase`.`caixa_plano_contas` (`idcaixa_plano_contas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_caixa_plano_contas_padrao_caixa_plano_contas3`
    FOREIGN KEY (`descontos_concedidos`)
    REFERENCES `5gprodatabase`.`caixa_plano_contas` (`idcaixa_plano_contas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_caixa_plano_contas_padrao_caixa_plano_contas4`
    FOREIGN KEY (`juros_pagos`)
    REFERENCES `5gprodatabase`.`caixa_plano_contas` (`idcaixa_plano_contas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_caixa_plano_contas_padrao_caixa_plano_contas5`
    FOREIGN KEY (`vendas`)
    REFERENCES `5gprodatabase`.`caixa_plano_contas` (`idcaixa_plano_contas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_caixa_plano_contas_padrao_caixa_plano_contas6`
    FOREIGN KEY (`contas_receber`)
    REFERENCES `5gprodatabase`.`caixa_plano_contas` (`idcaixa_plano_contas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_caixa_plano_contas_padrao_caixa_plano_contas7`
    FOREIGN KEY (`descontos_recebidos`)
    REFERENCES `5gprodatabase`.`caixa_plano_contas` (`idcaixa_plano_contas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_caixa_plano_contas_padrao_caixa_plano_contas8`
    FOREIGN KEY (`juros_recebidos`)
    REFERENCES `5gprodatabase`.`caixa_plano_contas` (`idcaixa_plano_contas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;



";
            return create;
        }
    }
}

