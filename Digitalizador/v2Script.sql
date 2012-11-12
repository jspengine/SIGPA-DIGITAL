/*
* Definindo o campo id do documento da tabela tipo documento como auto icremento.... [Manuten��o de dados]
*/
ALTER TABLE `sigpa_digital`.`tipodocumento` CHANGE COLUMN `ID_TIPODOCUMENTO` `ID_TIPODOCUMENTO` DOUBLE NOT NULL AUTO_INCREMENT  ;

/*
*	Altera��o na tabela documentos
*/ 

ALTER TABLE `sigpa_digital`.`documento` DROP FOREIGN KEY `FK_TIPODOCUMENTO` ;

ALTER TABLE `sigpa_digital`.`documento` CHANGE COLUMN `ID_DOCUMENTO` `ID_DOCUMENTO` DOUBLE NOT NULL COMMENT 'Identificador do documento'  , CHANGE COLUMN `NM_DOCUMENTO` `NM_DOCUMENTO` VARCHAR(100) NULL COMMENT 'Nome do Documento'  , CHANGE COLUMN `ID_TIPODOCUMENTO` `ID_TIPODOCUMENTO` DOUBLE NOT NULL COMMENT 'Identificador do Tipo de documento.'  , CHANGE COLUMN `DS_CATEGORIADOCUMENTO` `DS_CATEGORIADOCUMENTO` VARCHAR(1) NULL COMMENT 'Se o Documento � de um  processo Maritimo, A�reo,  Exporta��o, Rodovi�rio [M-A-E-R]'  , ADD COLUMN `NR_ORDEM` INT NOT NULL COMMENT 'n�mero que define a ordem do registro.'  AFTER `DS_CATEGORIADOCUMENTO` , 

  ADD CONSTRAINT `FK_TIPODOCUMENTO`

  FOREIGN KEY (`ID_TIPODOCUMENTO` )

  REFERENCES `sigpa_digital`.`tipodocumento` (`ID_TIPODOCUMENTO` )

  ON DELETE NO ACTION

  ON UPDATE NO ACTION;
/*
* Cria��o da tabela categoria de processo
*/

CREATE  TABLE `sigpa_digital`.`categoriaprocesso` (
  `id_categoriaprocesso` INT NOT NULL AUTO_INCREMENT ,
  `nm_categoriaprocesso` VARCHAR(45) NULL COMMENT 'O processo pode ser categorizado como a�reo, maritimo, rodovi�rio e de exporta��o' ,
  `ds_sigla` VARCHAR(2) NULL COMMENT 'Sigla usada para representar a categoria do a processo' ,
  PRIMARY KEY (`id_categoriaprocesso`) )
ENGINE = InnoDB;

INSERT INTO `sigpa_digital`.`categoriaprocesso` (`id_categoriaprocesso`, `nm_categoriaprocesso`, `ds_sigla`) VALUES ('1', 'A�reo', 'A');
INSERT INTO `sigpa_digital`.`categoriaprocesso` (`id_categoriaprocesso`, `nm_categoriaprocesso`, `ds_sigla`) VALUES ('2', 'M�ritimo', 'M');
INSERT INTO `sigpa_digital`.`categoriaprocesso` (`id_categoriaprocesso`, `nm_categoriaprocesso`, `ds_sigla`) VALUES ('3', 'Rodovi�rio', 'R');
INSERT INTO `sigpa_digital`.`categoriaprocesso` (`id_categoriaprocesso`, `nm_categoriaprocesso`, `ds_sigla`) VALUES ('4', 'Exporta��o', 'E');