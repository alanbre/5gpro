-- Schema 5gprodatabase
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `5gprodatabase` DEFAULT CHARACTER SET utf8 ;
USE `5gprodatabase` ;

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
  `ativo` TINYINT NULL,
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

-- -----------------------------------------------------
-- Table `5gprodatabase`.`grupo_usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`grupo_usuario` (
  `idgrupousuario` INT NOT NULL,
  `nome` VARCHAR(60) NULL,
  PRIMARY KEY (`idgrupousuario`))
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `5gprodatabase`.`usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`usuario` (
  `idusuario` INT NOT NULL,
  `nome` VARCHAR(40) NOT NULL,
  `sobrenome` VARCHAR(50) NULL,
  `senha` VARCHAR(255) NOT NULL,
  `email` VARCHAR(60) NULL,
  `telefone` VARCHAR(45) NULL,
  `idgrupousuario` INT NOT NULL,
  PRIMARY KEY (`idusuario`),
  INDEX `fk_usuario_grupo_usuario1_idx` (`idgrupousuario` ASC) VISIBLE,
  CONSTRAINT `fk_usuario_grupo_usuario1`
    FOREIGN KEY (`idgrupousuario`)
    REFERENCES `5gprodatabase`.`grupo_usuario` (`idgrupousuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `5gprodatabase`.`unimedida`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`unimedida` (
  `idunimedida` INT NOT NULL,
  `sigla` VARCHAR(45) NULL,
  `descricao` VARCHAR(45) NULL,
  PRIMARY KEY (`idunimedida`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`item`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`item` (
  `iditem` INT NOT NULL,
  `descitem` VARCHAR(45) NOT NULL,
  `denominacaocompra` VARCHAR(45) NULL,
  `tipo` VARCHAR(45) NOT NULL,
  `referencia` VARCHAR(45) NULL,
  `valorentrada` DECIMAL(15,2) NULL,
  `valorsaida` DECIMAL(15,2) NULL,
  `estoquenecessario` DECIMAL(10,2) NULL,
  `idunimedida` INT NOT NULL,
  PRIMARY KEY (`iditem`),
  INDEX `fk_item_unimedida1_idx` (`idunimedida` ASC) VISIBLE,
  CONSTRAINT `fk_item_unimedida1`
    FOREIGN KEY (`idunimedida`)
    REFERENCES `5gprodatabase`.`unimedida` (`idunimedida`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `5gprodatabase`.`orcamento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`orcamento` (
  `idorcamento` INT NOT NULL,
  `data_cadastro` DATE NOT NULL,
  `data_vencimento` DATE NULL,
  `valor_total_itens` DECIMAL(10,2) NULL,
  `valor_orcamento` DECIMAL(10,2) NULL,
  `desconto_total_itens` DECIMAL(10,2) NULL,
  `desconto_orcamento` DECIMAL(10,2) NULL,
  `idpessoa` INT NULL,
  PRIMARY KEY (`idorcamento`),
  INDEX `fk_orcamento_pessoa1_idx` (`idpessoa` ASC) VISIBLE,
  CONSTRAINT `fk_orcamento_pessoa1`
    FOREIGN KEY (`idpessoa`)
    REFERENCES `5gprodatabase`.`pessoa` (`idpessoa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`orcamento_has_item`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`orcamento_has_item` (
  `idorcamento` INT NOT NULL,
  `iditem` INT NOT NULL,
  `quantidade` DECIMAL(10,2) NULL,
  `valor_unitario` DECIMAL(10,2) NULL,
  `valor_total` DECIMAL(10,2) NULL,
  `desconto_porc` DECIMAL(10,2) NULL,
  `desconto` DECIMAL(10,2) NULL,
  PRIMARY KEY (`idorcamento`, `iditem`),
  INDEX `fk_orcamento_has_item_item1_idx` (`iditem` ASC) VISIBLE,
  INDEX `fk_orcamento_has_item_orcamento1_idx` (`idorcamento` ASC) VISIBLE,
  CONSTRAINT `fk_orcamento_has_item_orcamento1`
    FOREIGN KEY (`idorcamento`)
    REFERENCES `5gprodatabase`.`orcamento` (`idorcamento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_orcamento_has_item_item1`
    FOREIGN KEY (`iditem`)
    REFERENCES `5gprodatabase`.`item` (`iditem`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `5gprodatabase`.`permissao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`permissao` (
  `idpermissao` INT NOT NULL,
  `nome` VARCHAR(45) NULL,
  `codigo` VARCHAR(60) NOT NULL,
  PRIMARY KEY (`idpermissao`),
  UNIQUE INDEX `codigo_UNIQUE` (`codigo` ASC) VISIBLE)
ENGINE = InnoDB;



-- -----------------------------------------------------
-- Table `5gprodatabase`.`permissao_has_grupo_usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`permissao_has_grupo_usuario` (
  `idpermissao` INT NOT NULL,
  `idgrupousuario` INT NOT NULL,
  `nivel` INT NOT NULL DEFAULT 0,
  PRIMARY KEY (`idpermissao`, `idgrupousuario`),
  INDEX `fk_permissao_has_grupo_usuario_grupo_usuario1_idx` (`idgrupousuario` ASC) VISIBLE,
  INDEX `fk_permissao_has_grupo_usuario_permissao1_idx` (`idpermissao` ASC) VISIBLE,
  CONSTRAINT `fk_permissao_has_grupo_usuario_permissao1`
    FOREIGN KEY (`idpermissao`)
    REFERENCES `5gprodatabase`.`permissao` (`idpermissao`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_permissao_has_grupo_usuario_grupo_usuario1`
    FOREIGN KEY (`idgrupousuario`)
    REFERENCES `5gprodatabase`.`grupo_usuario` (`idgrupousuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `5gprodatabase`.`notafiscal`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`notafiscal` (
  `idnotafiscal` INT NOT NULL,
  `data_emissao` DATE NOT NULL,
  `data_entradasaida` DATE NOT NULL,
  `tiponf` CHAR(1) NOT NULL,
  `valor_total_itens` DECIMAL(10,2) NULL,
  `valor_documento` DECIMAL(10,2) NULL,
  `desconto_total_itens` DECIMAL(10,2) NULL,
  `desconto_documento` DECIMAL(10,2) NULL,
  `idpessoa` INT NULL,
  PRIMARY KEY (`idnotafiscal`),
  INDEX `fk_notafiscal_pessoa1_idx` (`idpessoa` ASC) VISIBLE,
  CONSTRAINT `fk_notafiscal_pessoa1`
    FOREIGN KEY (`idpessoa`)
    REFERENCES `5gprodatabase`.`pessoa` (`idpessoa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`notafiscal_has_item`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`notafiscal_has_item` (
  `idnotafiscal` INT NOT NULL,
  `iditem` INT NOT NULL,
  `quantidade` DECIMAL(10,2) NULL,
  `valor_unitario` DECIMAL(10,2) NULL,
  `valor_total` DECIMAL(10,2) NULL,
  `desconto_porc` DECIMAL(10,2) NULL,
  `desconto` DECIMAL(10,2) NULL,
  PRIMARY KEY (`idnotafiscal`, `iditem`),
  INDEX `fk_notafiscal_has_item_item1_idx` (`iditem` ASC) VISIBLE,
  INDEX `fk_notafiscal_has_item_notafiscal1_idx` (`idnotafiscal` ASC) VISIBLE,
  CONSTRAINT `fk_notafiscal_has_item_notafiscal1`
    FOREIGN KEY (`idnotafiscal`)
    REFERENCES `5gprodatabase`.`notafiscal` (`idnotafiscal`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_notafiscal_has_item_item1`
    FOREIGN KEY (`iditem`)
    REFERENCES `5gprodatabase`.`item` (`iditem`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `5gprodatabase`.`logado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `5gprodatabase`.`logado` (
  `idlogado` INT NOT NULL AUTO_INCREMENT,
  `idusuario` INT(11) NOT NULL,
  `mac` VARCHAR(45) NULL,
  PRIMARY KEY (`idlogado`),
  INDEX `fk_usuariologado_usuario1_idx` (`idusuario` ASC) VISIBLE,
  CONSTRAINT `fk_usuariologado_usuario1`
    FOREIGN KEY (`idusuario`)
    REFERENCES `5gprodatabase`.`usuario` (`idusuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;
