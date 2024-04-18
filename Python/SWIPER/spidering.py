import scrapy

class Spiderman(scrapy.Spider):
    name = "spiderman"
    start_urls = ['https://a-mwen.github.io/cafe-delight/']

    # Parse the extraction received from the request
    def parse(self, response):
        # Extract data from the menu section
        for category in response.css('div.menu-category'):
            yield {
                'category': category.css('h3::text').get(),
                'items': category.css('ul li::text').getall()
            }

        # Extract data from the testimonials section
        for testimonial in response.css('.testimonial'):
            yield {
                'quote': testimonial.css('blockquote::text').get().strip(),
                'author': testimonial.css('cite::text').get().strip()
            }

        # Extract data from the hours of operation section
        for hour in response.css('#hours-of-operation p'):
            yield {
                'hour': hour.css('::text').get().strip()
            }

        # Extract data from the daily specials section
        for special in response.css('#daily-specials p'):
            yield {
                'special': special.css('::text').get().strip()
            }

        # Extract data from the social media section
        for link in response.css('#social-media a'):
            yield {
                'social_media_link': link.attrib['href']
            }

        # Extract data from the team members section
        for member in response.css('.team-member'):
            yield {
                'name': member.css('p::text').get().strip()
            }

        # Extract data from the contact section
        yield {
            'address': response.css('#contact p::text').get().strip(),
            'phone': response.css('#contact p::text')[1].get().strip(),
            'email': response.css('#contact p::text')[2].get().strip()
        }
      