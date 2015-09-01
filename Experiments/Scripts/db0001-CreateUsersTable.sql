CREATE TABLE users
(
  id serial NOT NULL,
  name character varying(40) NOT NULL,
  CONSTRAINT users_pkey PRIMARY KEY (id),
  CONSTRAINT users_name_check CHECK (name::text <> ''::text)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE distributors
  OWNER TO newton;