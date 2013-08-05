/**
 *		作用：		创建Account表
 * 		表名：		Account
 *		表的数量：	tableCount
 */
DELIMITER $$

DROP PROCEDURE IF EXISTS `Account`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Account`()
BEGIN
	DECLARE i INT DEFAULT 0;
	DECLARE tableCount INT DEFAULT 10;
	WHILE i < tableCount
	DO
		SET @STMT := CONCAT("CREATE  TABLE `account_", FORMAT(i, 0), "` (
					`id` INT(10) UNSIGNED NOT NULL ,
					`name` VARCHAR(45) NOT NULL ,
					`nickName` VARCHAR(45) NOT NULL ,
					`passward` VARCHAR(45) NOT NULL ,
					`createTime` BIGINT NOT NULL ,
					`clusterID` INT(10) UNSIGNED NOT NULL ,
					`serverID` INT(10) UNSIGNED NOT NULL ,
					`databaseId` INT(10) UNSIGNED NOT NULL ,
					`tableId` INT(10) UNSIGNED NOT NULL ,
					PRIMARY KEY (`Id`) )
					ENGINE = MYISAM  DEFAULT CHARSET=utf8;");
		PREPARE STMT FROM @STMT;
		EXECUTE STMT;
		SET i = i + 1;
	END WHILE;
END$$

DELIMITER ;

CALL `Account`();

DROP PROCEDURE IF EXISTS `Account`;
