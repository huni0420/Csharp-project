/*----테이블 생성----*/
create table menu (
    menu VARCHAR2(20) primary key,
    quantity number,
    tb_number number
);

create table mtotal(
    total number,
    time TIMESTAMP primary key
);
/*테이블 삭제*/
drop table mtotal;

/*더미 데이터 생성 예*/
insert into mtotal values(12344,'2022-02-18');
insert into mtotal values(12344,'2022-02-17');
insert into mtotal values(12344,'2022-02-16');
insert into mtotal values(12344,'2022-01-15');

/*테이블 조회*/
select * from mtotal;

/*데이터 삭제(날자)*/
delete from mtotal where time = '2022-03-19';

/*데이터 조회(날자)의 mtotal 부분만*/
select total from mtotal where time = '20220318';

/*데이터 조회(날자)*/
select * from mtotal where time = '2022-03-17';


/*------------sql문 예제 작성연습-------------*/
/*데이터 조회(날자) like문*/
select * from mtotal where time like '22%03%';
/*데이터 덧셈*/
update mtotal set total = total+80000 where time = '2022-02-18';
/*-------------------------------------------------------------*/

select * from menu;
delete from menu where tablenum = 1;

/*커밋은 반드시 하자!!!!!!!!!!!*/
commit;