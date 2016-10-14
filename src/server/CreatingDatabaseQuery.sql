-- MySQL Workbench Forward Engineering


--CREATE DATABASE [Planner];
--USE [Planner];

-- -----------------------------------------------------
-- Table `planner`.`Category`
-- -----------------------------------------------------
CREATE TABLE [Category] (
  [ID] INT NOT NULL,
  [Name] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([ID]));


-- -----------------------------------------------------
-- Table `planner`.`Note`
-- -----------------------------------------------------
CREATE TABLE [Note] (
  [ID] INT NOT NULL,
  [Title] VARCHAR(45) NOT NULL,
  [Text] VARCHAR(max) NULL DEFAULT NULL,
  [IsActive]  TINYINT NULL DEFAULT NULL,
  [CategoryID] INT NOT NULL,
  PRIMARY KEY ([ID]),
  CONSTRAINT [fk_Note_Category_CategoryID]
    FOREIGN KEY ([CategoryID])
    REFERENCES [Category] ([ID])
    ON DELETE CASCADE
    ON UPDATE CASCADE);


-- -----------------------------------------------------
-- Table `planner`.`Priority`
-- -----------------------------------------------------
CREATE TABLE [Priority] (
  [ID] INT NOT NULL,
  [Name] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([ID]));


-- -----------------------------------------------------
-- Table `planner`.`Reminder`
-- -----------------------------------------------------
CREATE TABLE [Reminder] (
  [ID] INT NOT NULL,
  [TimeBefore] DATETIME NULL,
  PRIMARY KEY ([ID]));


-- -----------------------------------------------------
-- Table `planner`.`Task`
-- -----------------------------------------------------
CREATE TABLE [Task] (
  [ID] INT NOT NULL,
  [Title] VARCHAR(45) NOT NULL,
  [Date] DATETIME NOT NULL,
  [StartTime] DATETIME NOT NULL,
  [EndTime] DATETIME NOT NULL,
  [Place] VARCHAR(45) NULL,
  [Description] VARCHAR(45) NULL,
  [ReminderID] INT NULL,
  [PriorityID] INT NOT NULL,
  [CategoryID] INT NOT NULL,
  PRIMARY KEY ([ID]),
  CONSTRAINT [fk_Task_Reminder_ReminderID]
    FOREIGN KEY ([ReminderID])
    REFERENCES [Reminder] ([ID]),
  CONSTRAINT [fk_Task_Priority_PriorityID]
    FOREIGN KEY ([PriorityID])
    REFERENCES [Priority] ([ID]),
  CONSTRAINT [fk_Task_category1]
    FOREIGN KEY ([CategoryID])
    REFERENCES [Category] ([ID])
    ON DELETE CASCADE
    ON UPDATE CASCADE);
