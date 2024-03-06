# https://realpython.com/factory-method-python/

import json
import xml.etree.ElementTree as et

class Song:
    def __init__(self, song_id, title, artist):
        self.song_id = song_id
        self.title = title
        self.artist = artist


class SongSerializer:
    def serialize(self, song, format):
        if format == 'JSON':
            song_info = {
                'id': song.song_id,
                'title': song.title,
                'artist': song.artist
            }
            return json.dumps(song_info)
        elif format == 'XML':
            song_info = et.Element('song', attrib={'id': song.song_id})
            title = et.SubElement(song_info, 'title')
            title.text = song.title
            artist = et.SubElement(song_info, 'artist')
            artist.text = song.artist
            return et.tostring(song_info, encoding='unicode')
        else:
            raise ValueError(format)


"""
Problems with the class above:
    1. Using if/elif/else in logical code(serialize) conditional structures makes the code harder to read, harder to understand, and harder to maintain

    2. When a new format is introduced like JSON API

    3. When the Song object changes i.e. adding or removing properties.

    4. When the string representation for a format changes (plain JSON vs JSON API)
"""
