CREATE DATABASE ciberinfraestructura;

CREATE TABLE IF NOT EXISTS `ciberinfraestructura`.`CatPersonal` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(80) NOT NULL,
  `Cargo` VARCHAR(80) NOT NULL,
  PRIMARY KEY (`ID`))
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `ciberinfraestructura`.`CatProducto` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `Descripcion` VARCHAR(40) NOT NULL,
  PRIMARY KEY (`ID`))
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `ciberinfraestructura`.`tblInventario` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `FechaAlta` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `CatProducto_ID` INT NOT NULL,
  `Cantidad` INT NOT NULL DEFAULT 1,
  PRIMARY KEY (`ID`, `CatProducto_ID`),
  INDEX `fk_tblInventario_CatProducto_idx` (`CatProducto_ID` ASC) VISIBLE,
  CONSTRAINT `fk_tblInventario_CatProducto`
    FOREIGN KEY (`CatProducto_ID`)
    REFERENCES `ciberinfraestructura`.`CatProducto` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;