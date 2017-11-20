-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 20 Nov 2017 pada 10.32
-- Versi Server: 10.1.28-MariaDB
-- PHP Version: 7.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `movie_catalog`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `last_watched`
--

CREATE TABLE `last_watched` (
  `movie_id` int(11) NOT NULL,
  `current_position` double NOT NULL,
  `movie_duration` double NOT NULL,
  `last_watched_date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `last_watched`
--

INSERT INTO `last_watched` (`movie_id`, `current_position`, `movie_duration`, `last_watched_date`) VALUES
(205596, 1730997, 6853888, '2017-11-19 11:18:30'),
(293310, 1168270, 6809385, '2017-11-19 11:18:05');

-- --------------------------------------------------------

--
-- Struktur dari tabel `movies`
--

CREATE TABLE `movies` (
  `id` int(11) UNSIGNED NOT NULL,
  `title` varchar(100) NOT NULL,
  `description` text NOT NULL,
  `release_year` date NOT NULL,
  `poster_path` varchar(255) NOT NULL,
  `movie_path` varchar(100) NOT NULL,
  `subtitle_path` text NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `movies`
--

INSERT INTO `movies` (`id`, `title`, `description`, `release_year`, `poster_path`, `movie_path`, `subtitle_path`, `created_at`) VALUES
(205596, 'The Imitation Game', 'Based on the real life story of legendary cryptanalyst Alan Turing, the film portrays the nail-biting race against time by Turing and his brilliant team of code-breakers at Britain\'s top-secret Government Code and Cypher School at Bletchley Park, during the darkest days of World War II.', '2014-11-14', '205596.jpg', '205596.mkv', '205596.srt', '2017-11-19 19:08:57'),
(281957, 'The Revenant', 'In the 1820s, a frontiersman, Hugh Glass, sets out on a path of vengeance against those who left him for dead after a bear mauling.', '2015-12-25', '281957.jpg', '281957.mp4', '281957.srt', '2017-11-19 19:10:24'),
(284052, 'Doctor Strange', 'After his career is destroyed, a brilliant but arrogant surgeon gets a new lease on life when a sorcerer takes him under his wing and trains him to defend the world against evil.', '2016-10-25', '284052.jpg', '284052.mkv', '284052.srt', '2017-11-19 19:14:36'),
(293310, 'Citizenfour', 'In June 2013, Laura Poitras and reporter Glenn Greenwald flew to Hong Kong for the first of many meetings with Edward Snowden. She brought her camera with her. The film that resulted from this series of tense encounters is absolutely sui generis in the history of cinema:  a 100% real-life thriller unfolding minute by minute before our eyes. Poitras is a great and brave filmmaker, but she is also a masterful storyteller: she compresses the many days of questioning, waiting, confirming, watching the worldâ€™s reaction and agonizing over the next move, into both a great character study of Snowden and a narrative that will leave you on the edge of your seat as it inexorably moves toward its conclusion.', '2014-10-10', '293310.jpg', '293310.mp4', '293310.srt', '2017-11-19 19:11:45'),
(296524, 'Deepwater Horizon', 'A story set on the offshore drilling rig Deepwater Horizon, which exploded during April 2010 and created the worst oil spill in U.S. history.', '2016-09-29', '296524.jpg', '296524.mp4', '296524.srt', '2017-11-19 19:13:50');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `last_watched`
--
ALTER TABLE `last_watched`
  ADD PRIMARY KEY (`movie_id`);

--
-- Indexes for table `movies`
--
ALTER TABLE `movies`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
