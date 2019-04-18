-- MySQL Workbench Forward Engineering

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
CREATE SCHEMA IF NOT EXISTS `5gprodatabase` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `5gprodatabase` ;

-- -----------------------------------------------------
-- Table `5gprodatabase`.`atuacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`atuacao` (
  `idatuacao` INT(11) NOT NULL,
  `descricao` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idatuacao`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


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
  PRIMARY KEY (`idpessoa`),
  INDEX `fk_pessoa_cidade1_idx` (`idcidade` ASC) VISIBLE,
  CONSTRAINT `fk_pessoa_cidade1`
    FOREIGN KEY (`idcidade`)
    REFERENCES `5gprodatabase`.`cidade` (`idcidade`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`atuacao_has_pessoa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`atuacao_has_pessoa` (
  `atuacao_idatuacao` INT(11) NOT NULL,
  `pessoa_idpessoa` INT(11) NOT NULL,
  `ativo` TINYINT(1) NULL DEFAULT NULL,
  PRIMARY KEY (`atuacao_idatuacao`, `pessoa_idpessoa`),
  INDEX `fk_atuacao_has_pessoa_pessoa1_idx` (`pessoa_idpessoa` ASC) VISIBLE,
  INDEX `fk_atuacao_has_pessoa_atuacao1_idx` (`atuacao_idatuacao` ASC) VISIBLE,
  CONSTRAINT `fk_atuacao_has_pessoa_atuacao1`
    FOREIGN KEY (`atuacao_idatuacao`)
    REFERENCES `5gprodatabase`.`atuacao` (`idatuacao`),
  CONSTRAINT `fk_atuacao_has_pessoa_pessoa1`
    FOREIGN KEY (`pessoa_idpessoa`)
    REFERENCES `5gprodatabase`.`pessoa` (`idpessoa`))
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
  `idunimedida` INT(11) NOT NULL,
  `sigla` VARCHAR(45) NULL DEFAULT NULL,
  `descricao` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`idunimedida`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


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
  PRIMARY KEY (`iditem`),
  INDEX `fk_item_unimedida1_idx` (`idunimedida` ASC) VISIBLE,
  CONSTRAINT `fk_item_unimedida1`
    FOREIGN KEY (`idunimedida`)
    REFERENCES `5gprodatabase`.`unimedida` (`idunimedida`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`notafiscal`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`notafiscal` (
  `idnotafiscal` INT(11) NOT NULL,
  `data_emissao` DATE NOT NULL,
  `data_entradasaida` DATE NOT NULL,
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
  `idpermissao` INT(11) NOT NULL,
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
  `idlogado` INT NOT NULL AUTO_INCREMENT,
  `idusuario` INT(11) NOT NULL,
  `mac` VARCHAR(45) NULL,
  `nomepc` VARCHAR(45) NULL,
  `ipdopc` VARCHAR(45) NULL,
  `data_update` DATETIME NULL,
  PRIMARY KEY (`idlogado`),
  INDEX `fk_usuariologado_usuario1_idx` (`idusuario` ASC) VISIBLE,
  CONSTRAINT `fk_usuariologado_usuario1`
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
  `desconto` DECIMAL NULL,
  `entrada` DECIMAL NULL,
  PRIMARY KEY (`idoperacao`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`parcelaoperacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`parcelaoperacao` (
  `idparcelaoperacao` INT NOT NULL,
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


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
