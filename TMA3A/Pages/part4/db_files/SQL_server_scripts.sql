CREATE TABLE [component_types] (
  [id] INT NOT NULL IDENTITY(1, 1),
  [component_types] VARCHAR(255) NOT NULL,
  PRIMARY KEY ([id])
)
GO

CREATE TABLE [components] (
  [id] INT NOT NULL IDENTITY(1, 1),
  [component_name] VARCHAR(255) NOT NULL,
  [component_price] VARCHAR(255) NOT NULL,
  [component_image] text NOT NULL,
  [component_type] VARCHAR(255) NOT NULL,
  PRIMARY KEY ([id])
)
GO

CREATE TABLE [computers] (
  [id] INT NOT NULL IDENTITY(1, 1),
  [motherboard] VARCHAR(255) NOT NULL,
  [cpu] VARCHAR(255) NOT NULL,
  [gpu] VARCHAR(255) NOT NULL,
  [ram] VARCHAR(255) NOT NULL,
  [fan] VARCHAR(255) NOT NULL,
  [display] VARCHAR(255) NOT NULL,
  [operating_system] VARCHAR(255) NOT NULL,
  [soundcard] VARCHAR(255) NOT NULL,
  [harddrive] VARCHAR(255) NOT NULL,
  PRIMARY KEY ([id])
)
GO

CREATE TABLE [CPU] (
  [id] INT NOT NULL IDENTITY(1, 1),
  [link] VARCHAR(255) NOT NULL,
  [name] VARCHAR(255) NOT NULL,
  [price] VARCHAR(255) NOT NULL,
  [type] VARCHAR(255) NOT NULL,
  PRIMARY KEY ([id])
)
GO

CREATE TABLE [HardDrive] (
  [id] INT NOT NULL IDENTITY(1, 1),
  [link] VARCHAR(255) NOT NULL,
  [name] VARCHAR(255) NOT NULL,
  [price] VARCHAR(255) NOT NULL,
  [type] VARCHAR(255) NOT NULL,
  PRIMARY KEY ([id])
)
GO

CREATE TABLE [Motherboard] (
  [id] INT NOT NULL IDENTITY(1, 1),
  [link] VARCHAR(255) NOT NULL,
  [name] VARCHAR(255) NOT NULL,
  [price] VARCHAR(255) NOT NULL,
  [type] VARCHAR(255) NOT NULL,
  PRIMARY KEY ([id])
)
GO

CREATE TABLE [GPU] (
  [id] INT NOT NULL IDENTITY(1, 1),
  [link] VARCHAR(255) NOT NULL,
  [name] VARCHAR(255) NOT NULL,
  [price] VARCHAR(255) NOT NULL,
  [type] VARCHAR(255) NOT NULL,
  PRIMARY KEY ([id])
)
GO

CREATE TABLE [RAM] (
  [id] INT NOT NULL IDENTITY(1, 1),
  [link] VARCHAR(255) NOT NULL,
  [name] VARCHAR(255) NOT NULL,
  [price] VARCHAR(255) NOT NULL,
  [type] VARCHAR(255) NOT NULL,
  PRIMARY KEY ([id])
)
GO

CREATE TABLE [Fan] (
  [id] INT NOT NULL IDENTITY(1, 1),
  [link] VARCHAR(255) NOT NULL,
  [name] VARCHAR(255) NOT NULL,
  [price] VARCHAR(255) NOT NULL,
  [type] VARCHAR(255) NOT NULL,
  PRIMARY KEY ([id])
)
GO

CREATE TABLE [Display] (
  [id] INT NOT NULL IDENTITY(1, 1),
  [link] VARCHAR(255) NOT NULL,
  [name] VARCHAR(255) NOT NULL,
  [price] VARCHAR(255) NOT NULL,
  [type] VARCHAR(255) NOT NULL,
  PRIMARY KEY ([id])
)
GO

CREATE TABLE [operating_system] (
  [id] INT NOT NULL IDENTITY(1, 1),
  [link] VARCHAR(255) NOT NULL,
  [name] VARCHAR(255) NOT NULL,
  [price] VARCHAR(255) NOT NULL,
  [type] VARCHAR(255) NOT NULL,
  PRIMARY KEY ([id])
)
GO

CREATE TABLE [soundcard] (
  [id] INT NOT NULL IDENTITY(1, 1),
  [link] VARCHAR(255) NOT NULL,
  [name] VARCHAR(255) NOT NULL,
  [price] VARCHAR(255) NOT NULL,
  [type] VARCHAR(255) NOT NULL,
  PRIMARY KEY ([id])
)
GO

CREATE TABLE [users] (
  [id] INT NOT NULL IDENTITY(1, 1),
  [user_name] VARCHAR(255) NOT NULL,
  [passwrd] VARCHAR(255) NOT NULL,
  PRIMARY KEY ([id])
)
GO

CREATE TABLE [Orders] (
  [id] INT NOT NULL IDENTITY(1, 1),
  [user_name] VARCHAR(255) NOT NULL,
  [date] VARCHAR(255) NOT NULL,
  PRIMARY KEY ([id])
)
GO

CREATE TABLE [Cart] (
  [order_id] INT NOT NULL IDENTITY(1, 1),
  [items] VARCHAR(255) NOT NULL,
  [price] VARCHAR(255) NOT NULL,
  PRIMARY KEY ([order_id])
)
GO

ALTER TABLE [components] ADD FOREIGN KEY ([component_name]) REFERENCES [Motherboard] ([name])
GO

ALTER TABLE [components] ADD FOREIGN KEY ([component_name]) REFERENCES [HardDrive] ([name])
GO

ALTER TABLE [components] ADD FOREIGN KEY ([component_name]) REFERENCES [CPU] ([name])
GO

ALTER TABLE [components] ADD FOREIGN KEY ([component_name]) REFERENCES [GPU] ([name])
GO

ALTER TABLE [components] ADD FOREIGN KEY ([component_name]) REFERENCES [RAM] ([name])
GO

ALTER TABLE [components] ADD FOREIGN KEY ([component_name]) REFERENCES [operating_system] ([name])
GO

ALTER TABLE [components] ADD FOREIGN KEY ([component_name]) REFERENCES [Fan] ([name])
GO

ALTER TABLE [components] ADD FOREIGN KEY ([component_name]) REFERENCES [Display] ([name])
GO

ALTER TABLE [components] ADD FOREIGN KEY ([component_name]) REFERENCES [soundcard] ([name])
GO

ALTER TABLE [components] ADD FOREIGN KEY ([component_type]) REFERENCES [component_types] ([component_types])
GO

ALTER TABLE [Cart] ADD FOREIGN KEY ([order_id]) REFERENCES [Orders] ([id])
GO

ALTER TABLE [Orders] ADD FOREIGN KEY ([user_name]) REFERENCES [users] ([id])
GO

ALTER TABLE [computers] ADD FOREIGN KEY ([id]) REFERENCES [Cart] ([items])
GO

ALTER TABLE [components] ADD FOREIGN KEY ([id]) REFERENCES [Cart] ([items])
GO

CREATE UNIQUE INDEX [component_types_index_0] ON [component_types] ("component_types")
GO

CREATE UNIQUE INDEX [components_index_1] ON [components] ("component_name")
GO

CREATE UNIQUE INDEX [users_index_2] ON [users] ("user_name")
GO
