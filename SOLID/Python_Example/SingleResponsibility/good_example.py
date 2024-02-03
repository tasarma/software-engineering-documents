# https://realpython.com/solid-principles-python/

class FileManager:
    def __init__(self, filename):
        self.path = filename

    def read(self, encoding="utf-8"):
        pass

    def write(self, data, encoding="utf-8"):
        pass


class ZipFileManager:
    def __init__(self, filename):
        self.path = filename

    def compress(self):
        pass

    def decompress(self):
        pass
