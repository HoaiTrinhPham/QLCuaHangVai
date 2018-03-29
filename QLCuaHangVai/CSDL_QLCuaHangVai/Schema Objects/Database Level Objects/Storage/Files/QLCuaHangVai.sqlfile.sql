ALTER DATABASE [$(DatabaseName)]
    ADD FILE (NAME = [QLCuaHangVai], FILENAME = '$(DefaultDataPath)$(DatabaseName).mdf', FILEGROWTH = 1024 KB) TO FILEGROUP [PRIMARY];

