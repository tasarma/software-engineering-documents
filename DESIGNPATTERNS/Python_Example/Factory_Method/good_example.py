# https://realpython.com/factory-method-python/

import json
import xml.etree.ElementTree as et

class Song:
    def __init__(self, song_id, title, artist):
        self.song_id = song_id
        self.title = title
        self.artist = artist


class SongSerializer:

    # Client component of the Factory Method
    def serialize(self, song, format):
        serializer = get_serializer(format)
        return serializer(song)

    """
    # Creator component of the Factory Method
    def _get_serializer(self, format):
        if format == 'JSON':
            return self._serialize_to_json
        elif format == 'XML':
            return self._serialize_to_xml
        else:
            raise ValueError(format)

    # Concrete implementation of the Product compenent
    def _serialize_to_json(self, song):
        payload = {
            'id': song.song_id,
            'title': song.title,
            'artist': song.artist
        }
        return json.dumps(payload)

    # Concrete implementation of the Product compenent
    def _serialize_to_xml(self, song):
        song_element = et.Element('song', attrib={'id': song.song_id})
        title = et.SubElement(song_element, 'title')
        title.text = song.title
        artist = et.SubElement(song_element, 'artist')
        artist.text = song.artist
        return et.tostring(song_element, encoding='unicode')
        """

# Creator component of the Factory Method
def get_serializer(format):
    if format == 'JSON':
        return _serialize_to_json
    elif format == 'XML':
        return _serialize_to_xml
    else:
        raise ValueError(format)


# Creator component of the Factory Method
def _serialize_to_json(song):
    payload = {
        'id': song.song_id,
        'title': song.title,
        'artist': song.artist
    }
    return json.dumps(payload)


# Creator component of the Factory Method
def _serialize_to_xml(song):
    song_element = et.Element('song', attrib={'id': song.song_id})
    title = et.SubElement(song_element, 'title')
    title.text = song.title
    artist = et.SubElement(song_element, 'artist')
    artist.text = song.artist
    return et.tostring(song_element, encoding='unicode')

"""
Note1: None of the added methods use the self parameter. This is a good indication that they should not be methods of the SongSerializer class, and they can become external functions

Note2: The .serialize() method in SongSerializer does not use the self parameter. To Note1, it should not be part of the class.
But if you remove SongSerializer and change the .serialize() method to a function, then you’ll have to change all the locations in the application that use SongSerializer and replace the calls to the new function.
"""

"""
The final implementation shows the different components of Factory Method. The .serialize() method is the application code that depends on an interface to complete its task.

This is referred to as the 'client' component of the pattern. The interface defined is referred to as the 'product' component. In our case, the product is a function that takes a Song and returns a string representation.

The ._serialize_to_json() and ._serialize_to_xml() methods are concrete implementations of the product. Finally, the ._get_serializer() method is the 'creator' component. The creator decides which concrete implementation to use.
"""
