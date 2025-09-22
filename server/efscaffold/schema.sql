drop schema if exists project cascade;
create schema if not exists project;

create table project.todo(
                             id text not null primary key,
                             title text not null,
                             description text not null,
                             priority numeric not null,
                             isdone boolean not null);


