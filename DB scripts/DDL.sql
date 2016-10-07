/****************************************************************************/
/********************* Create table *****************************************/
/****************************************************************************/

create table farmer_dim (
f_id INT NOT NULL AUTO_INCREMENT,
First_name	varchar	(	35	),
middle_name	varchar	(	35	),
Last_name	varchar	(	35	),
Full_name	varchar	(	100	) not null,
DOB	date,
phone1	varchar	(	15	) not null,
phone2	varchar	(	15	),
phone3	varchar	(	15	),
farmer_rating	double,

primary key (f_id)

);


create table party_dim (
cust_id	INT NOT NULL AUTO_INCREMENT,
Cust_type_desc varchar	(	15	),
First_name	varchar	(	35	),
middle_name	varchar	(	35	),
Last_name	varchar	(	35	),
Full_name	varchar	(	100	) not null,
DOB	date,
phone1	varchar	(	15	) not null,
phone2	varchar	(	15	),
phone3	varchar	(	15	),
customer_rating	double,

primary key (cust_id)
);


create table address_dim (
address_id	INT NOT NULL AUTO_INCREMENT,
primary_entity_id	INT	not null,
primary_entity_type	varchar	(	10	),
address_line1	varchar	(	50	) not null,
address_line2	varchar	(	50	),
area	varchar	(	30	),
city_town	varchar	(	30	) not null,
state	varchar	(	30	) not null,
pin	varchar	(	10	) not null,
primary key (address_id)
);


create table item_dim (
item_id	INT NOT NULL AUTO_INCREMENT,
item_name	varchar	(	35	) not null,
quantity	double,
last_updated_dt	date not null,
category	varchar	(	20	),
sold_quantity	double,

primary key (item_id)
);



create table farmer_x_item (
f_id	INT NOT NULL ,
item_id	INT not null,
quantity	double,
last_updated_dt	date not null,
primary key (f_id,item_id)

);


create table order_dim (
order_id	INT NOT NULL,
cust_id	int not null,
Order_desc	varchar	(	50	),
delivery_address_id	int not null,
Priority_level int
order_status	varchar	(	20	),
order_date	date not null,
primary key (order_id)

);



create table order_x_item (
order_id	int not null,
item_id	int not null,
quantity	double not null,

primary key (order_id, item_id)
);


create table order_status(
order_id	int not null,
current_status	varchar(20) not null,
last_updated_timestamp	timestamp not null,

primary key (order_id, current_status)
);



create table rating (
primary_entity_id	int not null,
primary_entity_type	varchar(20),
rating	double,
time_stamp	timestamp	
order_id	int not null,
given_by	int,

primary key (primary_entity_id, order_id)
);


create table order_x_farmer(
order_id	int not null,
item_id	int not null,
f_id	int not null,
quantity	double,

primary key (order_id, item_id, f_id)
);


/****************************************************************************/
/**************** indexs ****************************************************/
/****************************************************************************/


create index farmer_name on farmer_dim(full_name);
create index farmer_mob on farmer_dim(phone1);

create index party_name on party_dim(full_name);
create index party_mob on party_dim(phone1);

create index pin_index on address_dim(pin);
create index primary_entity on address_dim(primary_entity_id);
create index area_index on address_dim(area);
create index city_index on address_dim(city_town);

create index item_category on item_dim(category);
create index item_name on item_dim(item_name);
create index last_updated_dt_ind on item_dim(last_updated_dt);

create index cust_ind on order_dim(cust_id);
create index order_dt_ind on order_dim(order_date);



/****************************************************************************/
/**************** Foreign key constraints ***********************************/
/****************************************************************************/

ALTER TABLE farmer_x_item
ADD FOREIGN KEY (f_id)
REFERENCES farmer_dim(f_id);

ALTER TABLE farmer_x_item
ADD FOREIGN KEY (item_id)
REFERENCES item_dim(item_id);

ALTER TABLE order_dim
ADD FOREIGN KEY (cust_id)
REFERENCES party_dim(cust_id);

ALTER TABLE order_dim
ADD FOREIGN KEY (delivery_address_id)
REFERENCES address_dim(delivery_address_id);

ALTER TABLE order_x_item
ADD FOREIGN KEY (order_id)
REFERENCES order_dim(order_id);

ALTER TABLE order_x_item
ADD FOREIGN KEY (item_id)
REFERENCES item_dim(item_id);

ALTER TABLE order_status
ADD FOREIGN KEY (order_id)
REFERENCES order_dim(order_id);

ALTER TABLE rating
ADD FOREIGN KEY (order_id)
REFERENCES order_dim(order_id);

ALTER TABLE order_x_farmer
ADD FOREIGN KEY (order_id)
REFERENCES order_dim(order_id);

ALTER TABLE order_x_farmer
ADD FOREIGN KEY (item_id)
REFERENCES item_dim(item_id);

ALTER TABLE order_x_farmer
ADD FOREIGN KEY (f_id)
REFERENCES farmer_dim(f_id);

/****************************************************************************************/