<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
  xmlns:st="urn:students"
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <head>
        <title>
          Students list
        </title>
      </head>
      <body>
        <h1>Students:</h1>
        <ol>
          <xsl:for-each select="/st:students/st:student">
            <li>
              <ul>
                <li>
                  <b>Name: </b>
                  <xsl:value-of select="st:name"/>
                </li>
                <li>
                  <b>Sex: </b>
                  <xsl:value-of select="st:sex"/>
                </li>
                <li>
                  <b>Birthdate: </b>
                  <xsl:value-of select="st:birthdate"/>
                </li>
                <li>
                  <b>Phone: </b>
                  <xsl:value-of select="st:phone"/>
                </li>
                <li>
                  <b>Email: </b>
                  <xsl:value-of select="st:email"/>
                </li>
                <li>
                  <b>Course: </b>
                  <xsl:value-of select="st:course"/>
                </li>
                <li>
                  <b>Specialty: </b>
                  <xsl:value-of select="st:specialty"/>
                </li>
                <li>
                  <b>FN: </b>
                  <xsl:value-of select="st:facultynumber"/>
                </li>
                <li>
                  <b>Exams: </b>
                  <table style="border: 1px solid black">
                    <thead style="border-bottom: thick dotted #ff0000">
                      <th style="background: #CDD; border-bottom: 1px solid yellowgreen">Name</th>
                      <th style="background: #CDC; border-bottom: 1px solid yellowgreen">Tutor</th>
                      <th style="background: #DCC; border-bottom: 1px solid yellowgreen">Score</th>
                      <th style="background: #DDC; border-bottom: 1px solid yellowgreen">Tutor endorsement</th>
                    </thead>
                    <xsl:for-each select="st:takenexams/st:exam">
                      <tr>
                        <td style="background: #CEE; border-bottom: 1px solid yellowgreen">
                          <xsl:value-of select="st:name"/>
                        </td>
                        <td style="background: #CEC; border-bottom: 1px solid yellowgreen">
                          <xsl:value-of select="st:tutor"/>
                        </td>
                        <td style="background: #ECC; border-bottom: 1px solid yellowgreen">
                          <xsl:value-of select="st:score"/>
                        </td>
                        <td style="background: #EEC; border-bottom: 1px solid yellowgreen">
                          <xsl:value-of select="st:endorsement"/> 
                        </td>
                      </tr>
                    </xsl:for-each>
                  </table>
                </li>
              </ul>
            </li>
          </xsl:for-each>
        </ol>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
