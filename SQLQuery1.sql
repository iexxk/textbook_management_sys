select * from tb_user

select user_password from tb_user where user_name='root'

select user_name from tb_user where user_email='email' 

insert into tb_user (user_name,user_password,user_email) values('1','1','1')

select * from tb_storage

insert into tb_storage (book_name,book_number,book_price,storage_time) values('xx','1','10',GETDATE)


select * from BOOK where 书名 like '%web%' and 作者 like '%%'  
select * from BOOK where ISBN like '%web%' or 书名 like '%web%' or 作者 like '%web%' or 出版社 like '%web%' or 价格 like '%web%' or 复本量 like '%web%' or 库存量 like '%web%'


select * from BOOK where 书名 like '%web%'

update BOOK set ISBN='1231',书名='12',作者='',出版社='',价格='',复本量='',库存量='' where id=1

update BOOK set ISBN='fghj',书名='asdcv',
                            作者='qe',
                            出版社='qwe',
                            价格='123',
                            复本量='1',
                            库存量='2' where id=1

insert into BOOK (ISBN,书名,作者,出版社,价格,复本量,库存量) values('1','1','1','1','1','1','1')

delete from book where id=1