import psycopg2
import json

# Connect to your PostgreSQL database
conn = psycopg2.connect(
    dbname="cafe_inventory",
    user="postgres",
    password="317!!Musha4lyf",
    host="localhost",
    port="5437"
)

# Open a cursor to perform database operations
cur = conn.cursor()

# Load the JSON data from the file
with open('input.json') as f:
    data = json.load(f)

# Iterate over each entry in the JSON data and insert into the database
for item in data:
    cur.execute(
        "INSERT INTO cafe_data (welcome_message, description, menu_items, testimonials, hours_of_operation, daily_specials, social_media_links, team_members, address, phone, email) VALUES (%s, %s, %s, %s, %s, %s, %s, %s, %s, %s, %s)",
        (
            item['welcome_message'],
            item['description'],
            item['menu_items'],
            json.dumps(item['testimonials']),  # Convert to JSON string as testimonials is a list of dictionaries
            item['hours_of_operation'],
            item['daily_specials'],
            item['social_media_links'],
            item['team_members'],
            item['address'],
            item['phone'],
            item['email']
        )
    )

# Commit the transaction
conn.commit()

# Close communication with the database
cur.close()
conn.close()
