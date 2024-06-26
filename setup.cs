import setuptools

with open("README.md", "r") as fh:
    long_description = fh.read()

setuptools.setup(
    name="EniCrypt",
    version="0.0.1",
    author="Passpartoo",
    author_email="",
    description="A package to encrypt file using the encryption method of the Enigma machine",
    long_description=long_description,
    long_description_content_type="text/markdown",
    url="https://github.com/Passpartoo/EniCrypt",
    packages=setuptools.find_packages(),
    include_package_data=True,
    install_requires=[
        "xlrd==1.2.0",
        "XlsxWriter==1.2.6",
        "click==6.7",
    ],
    classifiers=[
        "Programming Language :: C#",
        "License :: OSI Approved :: MIT License",
        "Operating System :: OS Independent",
    ],
)
