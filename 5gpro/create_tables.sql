-- -----------------------------------------------------
-- Table `5gprodatabase`.`pais`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`pais` (
  `idpais` INT NOT NULL,
  `nome` VARCHAR(45) NULL,
  `sigla` VARCHAR(45) NULL,
  PRIMARY KEY (`idpais`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`estado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`estado` (
  `idestado` INT NOT NULL,
  `nome` VARCHAR(45) NULL,
  `uf` CHAR(2) NULL,
  `idpais` INT NOT NULL,
  PRIMARY KEY (`idestado`),
  INDEX `fk_estado_pais1_idx` (`idpais` ASC) VISIBLE,
  CONSTRAINT `fk_estado_pais1`
    FOREIGN KEY (`idpais`)
    REFERENCES `5gprodatabase`.`pais` (`idpais`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`cidade`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`cidade` (
  `idcidade` INT NOT NULL,
  `nome` VARCHAR(45) NULL,
  `idestado` INT NOT NULL,
  PRIMARY KEY (`idcidade`),
  INDEX `fk_cidade_estado1_idx` (`idestado` ASC) VISIBLE,
  CONSTRAINT `fk_cidade_estado1`
    FOREIGN KEY (`idestado`)
    REFERENCES `5gprodatabase`.`estado` (`idestado`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`pessoa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`pessoa` (
  `idpessoa` INT NOT NULL,
  `nome` VARCHAR(255) NOT NULL,
  `fantasia` VARCHAR(255) NULL,
  `rua` VARCHAR(150) NULL,
  `numero` VARCHAR(10) NULL,
  `bairro` VARCHAR(45) NULL,
  `complemento` VARCHAR(45) NULL,
  `cpf` VARCHAR(11) NULL,
  `cnpj` VARCHAR(14) NULL,
  `endereco` VARCHAR(45) NULL,
  `telefone` VARCHAR(45) NULL,
  `email` VARCHAR(45) NULL,
  `tipo_pessoa` CHAR(1) NULL,
  `idcidade` INT NOT NULL,
  PRIMARY KEY (`idpessoa`),
  INDEX `fk_pessoa_cidade1_idx` (`idcidade` ASC) VISIBLE,
  CONSTRAINT `fk_pessoa_cidade1`
    FOREIGN KEY (`idcidade`)
    REFERENCES `5gprodatabase`.`cidade` (`idcidade`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`atuacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`atuacao` (
  `idatuacao` INT NOT NULL,
  `descricao` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idatuacao`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`atuacao_has_pessoa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`atuacao_has_pessoa` (
  `atuacao_idatuacao` INT NOT NULL,
  `pessoa_idpessoa` INT NOT NULL,
  PRIMARY KEY (`atuacao_idatuacao`, `pessoa_idpessoa`),
  INDEX `fk_atuacao_has_pessoa_pessoa1_idx` (`pessoa_idpessoa` ASC) VISIBLE,
  INDEX `fk_atuacao_has_pessoa_atuacao1_idx` (`atuacao_idatuacao` ASC) VISIBLE,
  CONSTRAINT `fk_atuacao_has_pessoa_atuacao1`
    FOREIGN KEY (`atuacao_idatuacao`)
    REFERENCES `5gprodatabase`.`atuacao` (`idatuacao`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_atuacao_has_pessoa_pessoa1`
    FOREIGN KEY (`pessoa_idpessoa`)
    REFERENCES `5gprodatabase`.`pessoa` (`idpessoa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`configuracao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`configuracao` (
  `idconfiguracao` INT NOT NULL,
  `variavel` VARCHAR(200) NULL,
  `valor` VARCHAR(200) NULL,
  PRIMARY KEY (`idconfiguracao`))
ENGINE = InnoDB;