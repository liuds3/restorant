-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 17, 2023 at 04:53 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `restoranas`
--

-- --------------------------------------------------------

--
-- Table structure for table `meniu`
--

CREATE TABLE `meniu` (
  `id` int(11) NOT NULL,
  `maistopavadinimas` varchar(30) NOT NULL,
  `gerimopavadinimas` varchar(30) NOT NULL,
  `kaina` int(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(5) NOT NULL,
  `name` varchar(15) NOT NULL,
  `email` varchar(40) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `name`, `email`, `password`) VALUES
(24, 'Useris2', 'useris2@gmail.com', 'randomizas'),
(28, 'Useris4', 'useris4@gmail.c', 'passwordz'),
(111, 'useris1', 'useris1@gmail.c', 'kebabas123'),
(121, 'mykolas', 'mykolas@gmail.c', 'cesnakinis'),
(141, 'karpol2', 'karpol2@gmail.c', 'kentauras'),
(153, 'kazka', 'kazka@gmail.com', 'kentauras'),
(154, 'testasAI', 'testasAi@gmail.', 'alioo'),
(156, 'test55', 'test55@gmail.co', 'neeeeee'),
(164, 'kazom', 'kazom@gmail.com', 'kazom123'),
(165, 'Names', 'name@gmail.com', 'name123'),
(167, 'admin', 'admin@gmail.com', 'admin'),
(169, 'karkar', 'karolispolisciukas0@gmail.com', '123456');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `meniu`
--
ALTER TABLE `meniu`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `name` (`name`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `meniu`
--
ALTER TABLE `meniu`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=170;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
