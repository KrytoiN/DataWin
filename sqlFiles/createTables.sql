drop database bank;
create database bank;
use bank;

create table if not exists Sub1
(
	idNme int auto_increment not null primary key comment 'Номер подразделения 1 уровня',
    nme varchar(80) not null comment 'Название подразделения 1 уровня',
    CONSTRAINT Sub1_unique UNIQUE (nme)
);

create table if not exists Sub2
(
	idNme2 int auto_increment not null primary key comment 'Номер подразделения 2 уровня',
    idNme int comment 'Номер подразделения 1',
    nme varchar(80) not null comment 'Название подразделения 2',
	foreign key (idNme) references Sub1(idNme) on delete cascade on update cascade,
    CONSTRAINT idSub2_unique UNIQUE (idNme, nme)
);

create table if not exists Sub3
(
	idNme3 int auto_increment not null primary key comment 'Номер подразделения 3 уровня',
    idNme2 int not null comment 'Номер подразделения 2 уровня',
    nme varchar(80) not null comment 'Название подразделения 3 уровня',
	foreign key (idNme2) references Sub2(idNme2) on delete cascade on update cascade,
    CONSTRAINT idSub3_unique UNIQUE (idNme2, nme)
);

create table if not exists FreqProcess
(
	idFreq int auto_increment not null primary key comment 'Номер частоты реализации процесса',
    nme varchar(80) not null comment 'Название частоты реализации процесса',
    CONSTRAINT freq_unique UNIQUE (nme)
);

create table if not exists KindActivity
(
	idActiv int auto_increment not null primary key comment 'Номер вида деятельности',
    nme varchar(80) not null comment 'Название вида деятельности',
    CONSTRAINT activ_unique UNIQUE (nme)
);

create table if not exists RtoValues
(
	idRto int auto_increment not null primary key comment 'Номер RTO',
    nme varchar(20) not null comment 'Значение RTO',
    CONSTRAINT rtoVal_unique UNIQUE (nme)
);

create table if not exists OwnerProces
(
	idOwner int auto_increment not null primary key comment 'Номер владельца',
    nme varchar(80) not null comment 'ФИО владельца процесса',
    CONSTRAINT owner_unique UNIQUE (nme)
);

create table if not exists Tariffs
(
	idTariff int auto_increment not null primary key comment 'Номер тарифа',
    nme varchar(80) not null comment 'Название тарифа',
    exp varchar(80) not null comment 'Пояснение'
);

create table if not exists Proces
(
	idProcess int auto_increment not null primary key comment 'Номер процесса',
    idNme3 int comment 'Номер подразделения 3 уровня',
    idFreq int comment 'Номер частоты реализации процесса',
    idActiv int comment 'Номер вида деятельности',
    idOwner int comment 'Владелец процесса',
    idRto int comment 'Значение RTO',
    rtoPrev varchar(20) not null comment 'Предыдущее значение RTO',
    idTariff int comment 'Номер тарифа',
    nme varchar(80) not null comment 'Название процесса',
    foreign key (idNme3) references Sub3(idNme3) on delete cascade on update cascade,
    foreign key (idFreq) references FreqProcess(idFreq) on delete cascade on update cascade,
    foreign key (idActiv) references KindActivity(idActiv) on delete cascade on update cascade,
    foreign key (idOwner) references OwnerProces(idOwner) on delete cascade on update cascade,
    foreign key (idRto) references RtoValues(idRto) on delete cascade on update cascade,
    foreign key (idTariff) references Tariffs(idTariff) on delete cascade on update cascade,
    CONSTRAINT Proces_unique UNIQUE (nme)
);

create table if not exists Rto
(
	idRto int auto_increment not null primary key comment 'Номер RTO',
    idProcess int comment 'Номер процесса',
    timing2Hours varchar(5) not null comment '2 часа',
    timing4Hours varchar(5) not null comment '4 часа',
    timing8Hours varchar(5) not null comment '8 часов',
    timing24Hours varchar(5) not null comment '24 часа',
    timing5Days varchar(5) not null comment '5 дней',
    timing30Days varchar(5) not null comment '30 дней',
    impactDowntime varchar(60) not null comment 'Влияние от простоя',
    rto varchar(20) not null comment 'Значение RTO',
    rtoPrev varchar(20) not null comment 'Предыдущие значение RTO',
    foreign key (idProcess) references Proces(idProcess) on delete cascade on update cascade,
    CONSTRAINT Rto_unique UNIQUE (idProcess, impactDowntime)
);

-- create table if not exists Addictions
-- (
-- 	idAdd int auto_increment not null primary key comment 'Номер степени зависимости',
--     nme varchar(80) not null comment 'Название степени'
-- );

-- create table if not exists Systems
-- (
-- 	idSystem int auto_increment not null primary key comment 'Номер системы',
--     idProcess int comment 'Номер процесса и rto',
--     idAdd int comment 'Номер степени зависимости',
--     availab varchar(10) not null comment 'Наличие альтернативного пути функционирования',
--     strategy varchar(30) not null comment 'Стратегия действий в случае недоступности',
--     timing varchar(30) not null comment 'Сколько времени потребуется для задействования альтернативного пути функционирования бизнес-процесса без данной бизнес-системы',
--     nme varchar(80) not null comment 'Название бизнес системы',
--     foreign key (idProcess) references Rto(idProcess) on delete cascade on update cascade
-- );
