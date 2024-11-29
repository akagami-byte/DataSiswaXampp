-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 25, 2024 at 12:17 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `siswa`
--

-- --------------------------------------------------------

--
-- Table structure for table `siswadata`
--

CREATE TABLE `siswadata` (
  `id` int(11) NOT NULL,
  `NIM` varchar(100) DEFAULT NULL,
  `nama` varchar(100) DEFAULT NULL,
  `kelas` varchar(100) DEFAULT NULL,
  `alamat` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `nohp` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `siswadata`
--

INSERT INTO `siswadata` (`id`, `NIM`, `nama`, `kelas`, `alamat`, `email`, `nohp`) VALUES
(1, '102042430032', 'Divan', '01', 'Jl. Trampil', 'kanachan@gmail.com', '081234567890'),
(3, '1020424300010', 'Okarun', '03', 'Jl. Mencari Biji', 'nenekpeyot@gmail.com', '081821312990'),
(4, '102301230012', 'Ultraman', '02', 'jl. tokitatsu', 'anakpapah@gmail.com', '018201930129'),
(6, '102042430012', 'Aur Auran', '05', 'Jl. Malam', 'gabolehbandel@gmail.com', '081923902120'),
(8, '10231019290', 'HiuMadura', '01', 'Jl. Madura anzay', 'madurasokasik@gmail.com', '085151889050'),
(14, '102042430012', 'BuayaSkenah', '04', 'Jl. ke  mana aja', 'mangsacewek@gmail.com', '087199301209');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `siswadata`
--
ALTER TABLE `siswadata`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `siswadata`
--
ALTER TABLE `siswadata`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
