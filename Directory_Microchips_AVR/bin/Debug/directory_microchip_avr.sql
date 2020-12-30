-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Дек 28 2020 г., 17:46
-- Версия сервера: 10.3.22-MariaDB
-- Версия PHP: 7.1.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `directory_microchip_avr`
--

-- --------------------------------------------------------

--
-- Структура таблицы `corpus`
--

CREATE TABLE `corpus` (
  `corpus_ID` int(11) NOT NULL,
  `name` char(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `full_name` char(200) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `number_of_legs` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `corpus`
--

INSERT INTO `corpus` (`corpus_ID`, `name`, `full_name`, `number_of_legs`) VALUES
(1, 'PDIP', '', 28),
(2, 'PDIP', '', 40),
(3, 'PDIP', '', 44),
(4, 'TQFP', '', 32),
(5, 'TQFP', '', 44),
(6, 'TQFP', '', 64),
(7, 'TQFP', '', 100),
(8, 'MLF', '', 28),
(9, 'MLF', '', 44),
(10, 'MLF', '', 32),
(11, 'MLF', '', 64);

-- --------------------------------------------------------

--
-- Структура таблицы `data_memory`
--

CREATE TABLE `data_memory` (
  `data_memory_ID` int(11) NOT NULL,
  `name` char(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `full_name` char(200) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `number_of_bytes` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `data_memory`
--

INSERT INTO `data_memory` (`data_memory_ID`, `name`, `full_name`, `number_of_bytes`) VALUES
(1, 'EEPROM', 'Electrically Erasable Programmable Read-Only Memory', 256),
(2, 'EEPROM', 'Electrically Erasable Programmable Read-Only Memory', 512),
(3, 'EEPROM', 'Electrically Erasable Programmable Read-Only Memory', 1000),
(4, 'EEPROM', 'Electrically Erasable Programmable Read-Only Memory', 2000),
(5, 'EEPROM', 'Electrically Erasable Programmable Read-Only Memory', 4000),
(6, 'SRAM', 'Static Random Access Memory', 512),
(7, 'SRAM', 'Static Random Access Memory', 1000),
(8, 'SRAM', 'Static Random Access Memory', 2000),
(9, 'SRAM', 'Static Random Access Memory', 2500),
(10, 'SRAM', 'Static Random Access Memory', 4000);

-- --------------------------------------------------------

--
-- Структура таблицы `interfaces`
--

CREATE TABLE `interfaces` (
  `interfaces_ID` int(11) NOT NULL,
  `name` char(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `full_name` char(200) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `number_of_interfaces` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `interfaces`
--

INSERT INTO `interfaces` (`interfaces_ID`, `name`, `full_name`, `number_of_interfaces`) VALUES
(1, 'SPI', 'Serial Peripheral Interface', 1),
(2, 'SPI', 'Serial Peripheral Interface', 2),
(3, 'SPI', 'Serial Peripheral Interface', 3),
(4, 'TWI', 'Two-Wire Interface', 0),
(5, 'TWI', 'Two-Wire Interface', 1),
(6, 'UART', 'Universal Asynchronous Receiver/Transmitter', 1),
(7, 'UART', 'Universal Asynchronous Receiver/Transmitter', 2),
(8, 'UART', 'Universal Asynchronous Receiver/Transmitter', 4);

-- --------------------------------------------------------

--
-- Структура таблицы `microchip_avr`
--

CREATE TABLE `microchip_avr` (
  `microchip_avr_ID` int(11) NOT NULL,
  `microchip_name` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `program_memory` int(11) NOT NULL,
  `external_RAM` tinyint(1) NOT NULL,
  `number_of_commands` int(11) NOT NULL,
  `number_of_inputs_outputs` int(11) NOT NULL,
  `working_arequency` int(11) NOT NULL,
  `supply_voltage_V` float NOT NULL,
  `datasheet` char(200) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `corpus_ID` int(11) NOT NULL,
  `data_memory_ID` int(11) NOT NULL,
  `interfaces_ID` int(11) NOT NULL,
  `timer_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `microchip_avr`
--

INSERT INTO `microchip_avr` (`microchip_avr_ID`, `microchip_name`, `program_memory`, `external_RAM`, `number_of_commands`, `number_of_inputs_outputs`, `working_arequency`, `supply_voltage_V`, `datasheet`, `corpus_ID`, `data_memory_ID`, `interfaces_ID`, `timer_ID`) VALUES
(1, 'ATmega48', 4, 0, 131, 23, 10, 5.5, NULL, 1, 1, 2, 2),
(2, 'ATmega48', 4, 0, 131, 23, 10, 5.5, NULL, 4, 1, 2, 2),
(3, 'ATmega48', 4, 0, 131, 23, 10, 5.5, NULL, 8, 1, 2, 2),
(4, 'ATmega48', 4, 0, 131, 23, 10, 5.5, NULL, 10, 1, 2, 2),
(5, 'ATmega48', 4, 0, 131, 23, 10, 5.5, NULL, 1, 6, 2, 2),
(6, 'ATmega48', 4, 0, 131, 23, 10, 5.5, NULL, 8, 6, 2, 2),
(7, 'ATmega48', 4, 0, 131, 23, 10, 5.5, NULL, 10, 6, 2, 2),
(8, 'ATmega48', 4, 0, 131, 23, 10, 5.5, NULL, 1, 1, 2, 3),
(9, 'ATmega48', 4, 0, 131, 23, 10, 5.5, NULL, 4, 6, 2, 3),
(10, 'ATmega48', 4, 0, 131, 23, 10, 5.5, NULL, 1, 1, 5, 2),
(11, 'ATmega48', 4, 0, 131, 23, 10, 5.5, NULL, 1, 1, 6, 2),
(12, 'ATmega48V', 4, 0, 131, 23, 4, 5.5, NULL, 4, 1, 2, 2),
(13, 'ATmega48V', 4, 0, 131, 23, 4, 5.5, NULL, 8, 1, 2, 2),
(14, 'ATmega48V', 4, 0, 131, 23, 4, 5.5, NULL, 10, 1, 2, 2),
(15, 'ATmega48V', 4, 0, 131, 23, 4, 5.5, NULL, 4, 6, 2, 2),
(16, 'ATmega48V', 4, 0, 131, 23, 4, 5.5, NULL, 8, 6, 2, 2),
(17, 'ATmega48V', 4, 0, 131, 23, 4, 5.5, NULL, 10, 6, 2, 2),
(18, 'ATmega48V', 4, 0, 131, 23, 4, 5.5, NULL, 1, 1, 2, 3),
(19, 'ATmega48V', 4, 0, 131, 23, 4, 5.5, NULL, 4, 6, 2, 3),
(20, 'ATmega48V', 4, 0, 131, 23, 4, 5.5, NULL, 1, 1, 5, 2),
(21, 'ATmega48V', 4, 0, 131, 23, 4, 5.5, NULL, 1, 1, 5, 2),
(22, 'ATmega8515', 8, 1, 130, 35, 16, 5.5, NULL, 5, 2, 2, 2),
(23, 'ATmega8515', 8, 1, 130, 35, 16, 5.5, NULL, 7, 2, 2, 2),
(24, 'ATmega8515', 8, 1, 130, 35, 16, 5.5, NULL, 6, 1, 2, 2),
(25, 'ATmega8515', 8, 1, 130, 35, 16, 5.5, NULL, 7, 2, 2, 2),
(26, 'ATmega8515', 8, 1, 130, 35, 16, 5.5, NULL, 6, 2, 2, 2),
(27, 'ATmega8515', 8, 1, 130, 35, 16, 5.5, NULL, 5, 2, 2, 2),
(28, 'ATmega8515', 8, 1, 130, 35, 16, 5.5, NULL, 7, 2, 2, 3),
(29, 'ATmega8515', 8, 1, 130, 35, 16, 5.5, NULL, 6, 2, 2, 3),
(30, 'ATmega8515', 8, 1, 130, 35, 16, 5.5, NULL, 5, 1, 5, 2),
(31, 'ATmega8515', 8, 1, 130, 35, 16, 5.5, NULL, 7, 1, 6, 2);

-- --------------------------------------------------------

--
-- Структура таблицы `project`
--

CREATE TABLE `project` (
  `project_ID` int(11) NOT NULL,
  `Name` char(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `photo` blob DEFAULT NULL,
  `settings` char(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `description` char(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `photo_Of_scheme` blob DEFAULT NULL,
  `microchip_avr_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `project`
--

INSERT INTO `project` (`project_ID`, `Name`, `photo`, `settings`, `description`, `photo_Of_scheme`, `microchip_avr_ID`) VALUES
(1, 'ЗВУКА СВЕТОВОГО МЕЧА', NULL, 'http://avrproject.ru/publ/ustrojstvo_imitacii_zvuka_svetovogo_mecha/1-1-0-180', 'как собрать световой меч из Звездных войн', NULL, 1),
(2, 'ЗВУКА СВЕТОВОГО МЕЧА', NULL, 'http://avrproject.ru/publ/ustrojstvo_imitacii_zvuka_svetovogo_mecha/1-1-0-180', 'как собрать световой меч из Звездных войн', NULL, 7),
(3, 'ЗВУКА СВЕТОВОГО МЕЧА', NULL, 'http://avrproject.ru/publ/ustrojstvo_imitacii_zvuka_svetovogo_mecha/1-1-0-180', 'как собрать световой меч из Звездных войн', NULL, 8),
(4, 'УПРАВЛЕНИЕ ПИТАНИЕМ С ПОМОЩЬЮ ОДНОЙ КНОПКИ', NULL, 'http://avrproject.ru/publ/poleznaja_informacija/upravlenie_pitaniem_ustrojstva_odnoj_knopkoj/4-1-0-177', 'Как можно включать и выключать устройство на микроконтроллере одной кнопкой без фиксации и реализацию такого алгоритма в Bascom-AVR.', NULL, 22),
(5, 'УПРАВЛЕНИЕ ПИТАНИЕМ С ПОМОЩЬЮ ОДНОЙ КНОПКИ', NULL, 'http://avrproject.ru/publ/poleznaja_informacija/upravlenie_pitaniem_ustrojstva_odnoj_knopkoj/4-1-0-177', 'Как можно включать и выключать устройство на микроконтроллере одной кнопкой без фиксации и реализацию такого алгоритма в Bascom-AVR.', NULL, 28),
(6, 'УПРАВЛЕНИЕ ПИТАНИЕМ С ПОМОЩЬЮ ОДНОЙ КНОПКИ', NULL, 'http://avrproject.ru/publ/poleznaja_informacija/upravlenie_pitaniem_ustrojstva_odnoj_knopkoj/4-1-0-177', 'Как можно включать и выключать устройство на микроконтроллере одной кнопкой без фиксации и реализацию такого алгоритма в Bascom-AVR.', NULL, 25),
(7, 'УПРАВЛЕНИЕ ПИТАНИЕМ С ПОМОЩЬЮ ОДНОЙ КНОПКИ', NULL, 'http://avrproject.ru/publ/poleznaja_informacija/upravlenie_pitaniem_ustrojstva_odnoj_knopkoj/4-1-0-177', 'Как можно включать и выключать устройство на микроконтроллере одной кнопкой без фиксации и реализацию такого алгоритма в Bascom-AVR.', NULL, 27),
(8, 'СИСТЕМА ОПОВЕЩЕНИЯ С ДАТЧИКОМ ДВИЖЕНИЯ', NULL, 'http://avrproject.ru/publ/besprovodnaja_sistema_opoveshhenija_s_datchikom_dvizhenija/1-1-0-176', 'охранное устройство, которое включает в себя датчик движения и возможность передавать по радиоканалу сигнал об его срабатывании', NULL, 2),
(9, 'СИСТЕМА ОПОВЕЩЕНИЯ С ДАТЧИКОМ ДВИЖЕНИЯ', NULL, 'http://avrproject.ru/publ/besprovodnaja_sistema_opoveshhenija_s_datchikom_dvizhenija/1-1-0-176', 'охранное устройство, которое включает в себя датчик движения и возможность передавать по радиоканалу сигнал об его срабатывании', NULL, 31),
(10, 'СИСТЕМА ОПОВЕЩЕНИЯ С ДАТЧИКОМ ДВИЖЕНИЯ', NULL, 'http://avrproject.ru/publ/besprovodnaja_sistema_opoveshhenija_s_datchikom_dvizhenija/1-1-0-176', 'охранное устройство, которое включает в себя датчик движения и возможность передавать по радиоканалу сигнал об его срабатывании', NULL, 29);

-- --------------------------------------------------------

--
-- Структура таблицы `timer`
--

CREATE TABLE `timer` (
  `timer_ID` int(11) NOT NULL DEFAULT 0,
  `name` char(50) COLLATE utf8mb4_unicode_ci DEFAULT '',
  `number_of_timers` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `timer`
--

INSERT INTO `timer` (`timer_ID`, `name`, `number_of_timers`) VALUES
(1, '8-bit', 1),
(2, '8-bit', 2),
(3, '16-bit', 1),
(4, '16-bit', 2),
(5, '16-bit', 4);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `corpus`
--
ALTER TABLE `corpus`
  ADD PRIMARY KEY (`corpus_ID`);

--
-- Индексы таблицы `data_memory`
--
ALTER TABLE `data_memory`
  ADD PRIMARY KEY (`data_memory_ID`);

--
-- Индексы таблицы `interfaces`
--
ALTER TABLE `interfaces`
  ADD PRIMARY KEY (`interfaces_ID`);

--
-- Индексы таблицы `microchip_avr`
--
ALTER TABLE `microchip_avr`
  ADD PRIMARY KEY (`microchip_avr_ID`),
  ADD KEY `F_1` (`interfaces_ID`),
  ADD KEY `F_2` (`data_memory_ID`),
  ADD KEY `F_3` (`corpus_ID`),
  ADD KEY `F_4` (`timer_ID`);

--
-- Индексы таблицы `project`
--
ALTER TABLE `project`
  ADD PRIMARY KEY (`project_ID`),
  ADD KEY `F_5` (`microchip_avr_ID`);

--
-- Индексы таблицы `timer`
--
ALTER TABLE `timer`
  ADD PRIMARY KEY (`timer_ID`);

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `microchip_avr`
--
ALTER TABLE `microchip_avr`
  ADD CONSTRAINT `F_1` FOREIGN KEY (`interfaces_ID`) REFERENCES `interfaces` (`interfaces_ID`),
  ADD CONSTRAINT `F_2` FOREIGN KEY (`data_memory_ID`) REFERENCES `data_memory` (`data_memory_ID`),
  ADD CONSTRAINT `F_3` FOREIGN KEY (`corpus_ID`) REFERENCES `corpus` (`corpus_ID`),
  ADD CONSTRAINT `F_4` FOREIGN KEY (`timer_ID`) REFERENCES `timer` (`timer_ID`);

--
-- Ограничения внешнего ключа таблицы `project`
--
ALTER TABLE `project`
  ADD CONSTRAINT `F_5` FOREIGN KEY (`microchip_avr_ID`) REFERENCES `microchip_avr` (`microchip_avr_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
