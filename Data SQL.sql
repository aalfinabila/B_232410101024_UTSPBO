CREATE TABLE tugas(
 id tugas PRIMARY KEY,
    nama VARCHAR(100) NOT NULL,
    deskripsi VARCHAR (100) NOT NULL
);

INSERT INTO admin (nama, alamat, email, nomerhp, katasandi)VALUES 
('Nabila', 'Jember', 'alfinabila@gmail.com', 0812121212, 'nabil123'),
('Aldi', 'Surabaya', 'aldi@gmail.com', 0813131313, 'aldi123'),
('Najwa', 'Jakarta', 'najwa@gmail.com', 0814141414, 'najwa123')
;

CREATE TABLE admin(
 id SERIAL PRIMARY KEY,
    nama VARCHAR(100) NOT NULL,
    alamat VARCHAR(20) UNIQUE NOT NULL,
    email VARCHAR(100) NOT NULL,
    nomerhp INT NOT NULL,
    katasandi VARCHAR(100) NOT NULL
);

INSERT INTO admin (nama, alamat, email, nomerhp, katasandi)VALUES 
('Nabila', 'Jember', 'alfinabila@gmail.com', 0812121212, 'nabil123'),
('Aldi', 'Surabaya', 'aldi@gmail.com', 0813131313, 'aldi123'),
('Najwa', 'Jakarta', 'najwa@gmail.com', 0814141414, 'najwa123')
;

select * from admin