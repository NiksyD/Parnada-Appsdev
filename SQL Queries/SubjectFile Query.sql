CREATE TABLE SubjectFile (
    SFSUBJCODE VARCHAR(15),
    SFSUBJDESC VARCHAR(40),
    SFSUBJUNITS FLOAT,
    SFSUBJREGOFRNG INT CHECK (SFSUBJREGOFRNG IN (1, 2)),
    SFSUBJCATEGORY VARCHAR(3),
    SFSUBJSTATUS VARCHAR(2) CHECK (SFSUBJSTATUS IN ('AC', 'IN')),
    SFSUBJCOURSECODE VARCHAR(5),
    SFSUBJCURRCODE VARCHAR(10),
    PRIMARY KEY (SFSUBJCODE, SFSUBJCOURSECODE)
);
