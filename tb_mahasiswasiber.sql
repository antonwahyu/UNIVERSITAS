-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 02 Bulan Mei 2024 pada 16.40
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `universitas`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_mahasiswasiber`
--

CREATE TABLE `tb_mahasiswasiber` (
  `ID` int(11) NOT NULL,
  `Nama` varchar(255) NOT NULL,
  `NIM` varchar(255) NOT NULL,
  `Jenis_Kelamin` enum('Laki-Laki','Perempuan','','') NOT NULL,
  `Kelas` varchar(255) NOT NULL,
  `Program_Studi` varchar(255) NOT NULL,
  `Angkatan` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tb_mahasiswasiber`
--

INSERT INTO `tb_mahasiswasiber` (`ID`, `Nama`, `NIM`, `Jenis_Kelamin`, `Kelas`, `Program_Studi`, `Angkatan`) VALUES
(1, 'Anton Wahyu', '220401010170', 'Laki-Laki', 'IT 401', 'Informatika', '2023'),
(2, 'bayu sanjaya', '478798347', 'Laki-Laki', 'IT 401', 'Informatika', '2006');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tb_mahasiswasiber`
--
ALTER TABLE `tb_mahasiswasiber`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tb_mahasiswasiber`
--
ALTER TABLE `tb_mahasiswasiber`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
